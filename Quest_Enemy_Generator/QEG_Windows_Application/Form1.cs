using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Quest_Enemy_Generator;

namespace QEG_Windows_Application
{
    public partial class QEG_Form : Form
    {
        // Internal declarations
        DataManager dm = new DataManager();

        int avgLvl = 1;
        int count = 1;

        public QEG_Form()
        {
            InitializeComponent();
            randomModes.SelectedIndex = 0;
            avgPlrLvl.Text = 1.ToString();
            enemyCount.Text = 1.ToString();

            avgPlrLvl.Enter += (sender, args) =>
            {
                if (!int.TryParse(avgPlrLvl.Text, out avgLvl) || avgLvl <= 0)
                {
                    avgPlrLvl.Text = 1.ToString();
                    avgLvl = 1;
                }
            };

            enemyCount.Enter += (sender, args) =>
            {
                if (!int.TryParse(enemyCount.Text, out count) || avgLvl <= 0)
                {
                    enemyCount.Text = 1.ToString();
                    count = 1;
                }
            };

        }

        void Form1_Load(object sender, EventArgs e)
        { }

        void label1_Click(object sender, EventArgs e)
        { }

        void randomize_Click(object sender, EventArgs e)
        {
            // Set random mode
            dm.RMode = (RandomMode)randomModes.SelectedIndex;

            dm.FillEnemyList(avgLvl, count);

            UpdateAndDisplayToOutput();
        }

        void UpdateAndDisplayToOutput()
        {
            // Formatting Options
            dm.PrintWeaponsFull = displayFullWeapons.Checked;
            dm.PrintGlyphsFull = displayFullGlyphs.Checked;
            dm.PrintArmorFull = displayFullArmor.Checked;

            List<string> printList = dm.FormatListForDisplay();

            output.Clear();

            foreach (string s in printList)
            {
                output.AppendText(s);
            }

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

        void randomModes_SelectedIndexChanged(object sender, EventArgs e)
        { }

        void avgPlrLvl_TextChanged(object sender, EventArgs e)
        {
        }

        void enemyCount_TextChanged(object sender, EventArgs e)
        {
        }


    }
}