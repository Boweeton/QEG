using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Quest_Enemy_Generator;

namespace QEG_Windows_Application
{
    public partial class QegForm : Form
    {
        #region Data

        // == DATA ==
        DataManager dm = new DataManager();

        const int MaxPlayerLevel = 50;
        const int MaxEnemyCount = 100;

        int avgLvl = 1;
        int count = 1;

        #endregion

        #region Constructors

        // == CONSTRUCTORS ==
        public QegForm()
        {
            InitializeComponent();
            randomModes.SelectedIndex = 0;
            avgPlrLvlBox.Text = 1.ToString();
            enemyCountBox.Text = 1.ToString();

            // If you hit "enter" while in the avgPlrLvlBox, you go to enemyCountBox
            avgPlrLvlBox.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    args.SuppressKeyPress = true;
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            };

            // If you hit "enter" while in the enemyCountBox, you go to randomizeButton
            enemyCountBox.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    args.SuppressKeyPress = true;
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            };

            // Stupid proof the avgPlrLvlBox
            avgPlrLvlBox.Leave += (sender, args) =>
            {
                if (!int.TryParse(avgPlrLvlBox.Text, out avgLvl) || avgLvl <= 0)
                {
                    avgPlrLvlBox.Text = 1.ToString();
                    avgLvl = 1;
                }
                else if (avgLvl > MaxPlayerLevel)
                {
                    avgPlrLvlBox.Text = MaxPlayerLevel.ToString();
                    avgLvl = MaxPlayerLevel;
                }
            };

            // Stupid proof the enemyCountBox
            enemyCountBox.Leave += (sender, args) =>
            {
                if (!int.TryParse(enemyCountBox.Text, out count) || count <= 0)
                {
                    enemyCountBox.Text = 1.ToString();
                    count = 1;
                }
                else if (count > MaxEnemyCount)
                {
                    enemyCountBox.Text = MaxEnemyCount.ToString();
                    count = MaxEnemyCount;
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
                        case Keys.S when saveButton.Enabled:
                            SaveToFile();
                            break;
                        case Keys.R:
                            Rando();
                            break;
                    }
                }
            };

            saveButton.Enabled = false;
            gameClassNorowerBox.CheckOnClick = true;

        }

        #endregion

        #region Methods

        // == METHODS ==
        void Rando()
        {
            // Set random mode
            dm.RMode = (RandomMode)randomModes.SelectedIndex;

            // Assemble the list of AcceptableClasses
            // Clear the previous list
            dm.AcceptableClasses = new List<GameClassType>();

            // Go through each checkbox and add that enum if it's checked
            for (int i = 0; i < gameClassNorowerBox.Items.Count; i++)
            {
                if (gameClassNorowerBox.GetItemChecked(i))
                {
                    dm.AcceptableClasses.Add((GameClassType)i);
                }
            }

            // Generate the random enemy list
            dm.FillEnemyList(avgLvl, count);

            UpdateAndDisplayToOutput();

            // Make the save buttone active once the output box has been populated at least once
            if (!output.Text.Equals(""))
            {
                saveButton.Enabled = true;
            }
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

        void SaveToFile()
        {
            if (saveFileToTxtDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(saveFileToTxtDialog.FileName))
                {
                    sr.WriteLine(string.Join(Environment.NewLine, dm.FormatListForTxtPrinting()));
                }
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            // Auto set the Narrow Class
            for (int i = 0; i < gameClassNorowerBox.Items.Count; i++)
            {
                gameClassNorowerBox.SetItemCheckState(i, CheckState.Checked);
            }

            // Set the focus on to the avgPlrLvl box
            avgPlrLvlBox.Select();
            avgPlrLvlBox.SelectAll();
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

        void randomize_Click(object sender, EventArgs e)
        {
            Rando();
        }

        void printButton_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        #endregion
    }
}