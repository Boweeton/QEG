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

namespace XMLManager
{
    public partial class XmlManagerForm : Form
    {
        readonly DataManager dm;
        List<Glyph> currentGlyphs;

        public XmlManagerForm()
        {
            InitializeComponent();

            dm = new DataManager();

            // Load up the original glyph list

            // Mirror the current list to the loaded glyphs
            currentGlyphs = dm.Glyphs;
        }

        void XMLManagerForm_Load(object sender, EventArgs e)
        {
        }

        void OnSaveChangesButtonClick(object sender, EventArgs e)
        {
            const string Message = "Are you sure you want to Save Changes?";
            const string Caption = "Save Changes";
            const MessageBoxButtons Buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(Message, Caption, Buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SaveChangesToGlyphListFile();
            }
        }

        void OnDiscardChangesButtonClick(object sender, EventArgs e)
        {
            const string Message = "Are you sure you want to Discard Changes?";
            const string Caption = "Discard Changes";
            const MessageBoxButtons Buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(Message, Caption, Buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                GoBackToLoadedGlyphListFile();
            }
        }

        void SaveChangesToGlyphListFile()
        {

        }

        void GoBackToLoadedGlyphListFile()
        {

        }
    }
}
