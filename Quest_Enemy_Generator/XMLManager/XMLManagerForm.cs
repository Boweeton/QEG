using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Quest_Enemy_Generator;

namespace XMLManager
{
    public partial class XmlManagerForm : Form
    {
        List<Glyph> loadedGlyphs;
        List<Glyph> currentGlyphs;
        Glyph glyphToAdd;

        public XmlManagerForm()
        {
            InitializeComponent();

            // Load up the original glyph list

            // Mirror the current list to the loaded glyphs
            currentGlyphs = loadedGlyphs;
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
            currentGlyphs = loadedGlyphs;
        }

        void OnLoadGmtFilesButtonClick(object sender, EventArgs e)
        {
            if (loadGmtFilesInterface.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(loadGmtFilesInterface.FileName))
                {
                }
            }
        }

        void OnAddNewGlyphButtonClick(object sender, EventArgs e)
        {
            // Local declarations
            glyphToAdd = new Glyph();
        }

        void deleteSelectedGlyphButton_Click(object sender, EventArgs e)
        {
            const string Message = "Are you sure you want to Delete the Selected Glyph?";
            const string Caption = "Delete Selected Glyph";
            const MessageBoxButtons Buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(Message, Caption, Buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteSelectedGlyph();
            }
        }

        void DeleteSelectedGlyph()
        {
            
        }
    }
}
