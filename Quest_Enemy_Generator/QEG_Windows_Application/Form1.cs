using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Quest_Enemy_Generator;

namespace QEG_Windows_Application
{
    public partial class QEG_Form : Form
    {
        // Internal declarations
        DataManager dm = new DataManager();

        const int MaxPlayerLevel = 50;
        const int MaxEnemyCount = 100;

        int avgLvl = 1;
        int count = 1;

        public QEG_Form()
        {
            InitializeComponent();
            randomModes.SelectedIndex = 0;
            avgPlrLvlBox.Text = 1.ToString();
            enemyCountBox.Text = 1.ToString();

            avgPlrLvlBox.Leave += (sender, args) =>
            {
                if (!int.TryParse(avgPlrLvlBox.Text, out avgLvl) || avgLvl <= 0 || avgLvl > MaxPlayerLevel)
                {
                    avgPlrLvlBox.Text = 1.ToString();
                    avgLvl = 1;
                }
            };

            enemyCountBox.Leave += (sender, args) =>
            {
                if (!int.TryParse(enemyCountBox.Text, out count) || count <= 0 || count > MaxEnemyCount)
                {
                    enemyCountBox.Text = 1.ToString();
                    count = 1;
                }
            };

            avgPlrLvlBox.Click += (sender, args) => avgPlrLvlBox.SelectAll();
            enemyCountBox.Click += (sender, args) => enemyCountBox.SelectAll();

            KeyPreview = true;
            KeyDown += (sender, args) =>
            {
                if (args.Control)
                {
                    switch (args.KeyCode)
                    {
                        case Keys.S when printButton.Enabled:
                            SaveToFile();
                            break;
                        case Keys.R:
                            Rando();
                            break;
                    }
                }
            };

            printButton.Enabled = false;

        }

        void Form1_Load(object sender, EventArgs e)
        {
            // Set the focus on to the avgPlrLvl box
            avgPlrLvlBox.Select();
            avgPlrLvlBox.SelectAll();
        }

        void randomize_Click(object sender, EventArgs e)
        {
            Rando();
        }

        void Rando()
        {
            // Set random mode
            dm.RMode = (RandomMode)randomModes.SelectedIndex;

            dm.FillEnemyList(avgLvl, count);

            UpdateAndDisplayToOutput();

            printButton.Enabled = true;
        }

        void UpdateAndDisplayToOutput()
        {
            // Formatting Options
            dm.PrintWeaponsFull = displayFullWeapons.Checked;
            dm.PrintGlyphsFull = displayFullGlyphs.Checked;
            dm.PrintArmorFull = displayFullArmor.Checked;

            List<string> printList = dm.FormatListForDisplay();

            output.Clear();

            string printingString = string.Join(Environment.NewLine, printList);

            output.AppendText(printingString);

            // Scroll to top of output box
            output.SelectionStart = 0;
            output.SelectionLength = 1;
            output.ScrollToCaret();
        }

        void DisplayFullWeapons_CheckedChanged(object sender, EventArgs e)
        {
            if (dm.EnemyList != null)
            {
                UpdateAndDisplayToOutput();
            }
        }

        void displayFullGlyphs_CheckedChanged(object sender, EventArgs e)
        {
            if (dm.EnemyList != null)
            {
                UpdateAndDisplayToOutput();
            }
        }

        void displayFullArmor_CheckedChanged(object sender, EventArgs e)
        {
            if (dm.EnemyList != null)
            {
                UpdateAndDisplayToOutput();
            }
        }

        void printButton_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        void SaveToFile()
        {
            saveFileToTxtDialog.FileName = $"QEG_{DateTime.Now:MM-dd-yy_(hh.mm)}.txt";

            if (saveFileToTxtDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(saveFileToTxtDialog.FileName))
                {
                    sr.WriteLine(string.Join(Environment.NewLine, dm.FormatListForTxtPrinting()));
                }
            }
        }
    }
}