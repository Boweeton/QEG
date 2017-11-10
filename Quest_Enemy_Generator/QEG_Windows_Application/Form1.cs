using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quest_Enemy_Generator;

namespace QEG_Windows_Application
{
    public partial class QEG_Form : Form
    {
        // Internal declarations
        DataManager dm = new DataManager();

        public QEG_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AvgPlrLvl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void randomize_Click(object sender, EventArgs e)
        {
            dm.FillEnemyList(31, 4);
            UpdateAndDisplayToOutput();
        }

        void UpdateAndDisplayToOutput()
        {

            List<string> printList = dm.FormatListForDisplay();

            output.Clear();

            foreach (string s in printList)
            {
                output.AppendText(s);
            }
        }

        void DisplayFullWeapons_CheckedChanged(object sender, EventArgs e)
        {

        }

        void displayFullGlyphs_CheckedChanged(object sender, EventArgs e)
        {

        }

        void displayFullArmor_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
