using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using QEG_Classes;
using Quest_Enemy_Generator;

namespace XMLManager
{
    public partial class XmlManagerForm : Form
    {
        List<Glyph> loadedGlyphs;
        List<Glyph> currentGlyphs;
        Glyph glyphToAdd;
        TextBox currentSelectedBox;
        Glyph currentSelectedGlyph;
        Glyph prevSelectedGlyph;
        string path;

        public XmlManagerForm()
        {
            InitializeComponent();

            // Load up the original glyph list
            DataManager dm = new DataManager();
            loadedGlyphs = dm.Glyphs;

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

        void OnEditSelectedGlyphButtonClick(object sender, EventArgs e)
        {
            try
            {
                int pointX = 0;
                int pointY = 0;
                displayPanel.Controls.Clear();
                foreach (Glyph glyph in currentGlyphs)
                {
                    TextBox textBox = new TextBox();

                    textBox.Multiline = true;
                    textBox.BorderStyle = BorderStyle.FixedSingle;

                    Glyph currentGlyph = glyph;

                    // Create the "click change" method
                    textBox.Click += (o, args) =>
                    {
                        currentSelectedGlyph = currentGlyph;
                        if (currentSelectedBox != null)
                        {
                            currentSelectedBox.BackColor = Color.White;
                        }
                        currentSelectedBox = textBox;
                        // ReSharper disable once PossibleNullReferenceException
                        currentSelectedBox.BackColor = Color.LightSteelBlue;
                    };

                    textBox.Cursor = Cursors.Arrow;

                    textBox.BackColor = Color.White;
                    textBox.ReadOnly = true;

                    textBox.Text = glyph.ToEditorDisplay(displayPanel.Width);

                    textBox.Location = new Point(pointX, pointY);

                    // Set the box location
                    int currentHeight = glyph.ToSeachResultString(displayPanel.Width).CountLines() * textBox.Font.Height;
                    textBox.Height = currentHeight;
                    textBox.Width = displayPanel.Width - 18;

                    displayPanel.Controls.Add(textBox);
                    displayPanel.Show();
                    pointY += currentHeight;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
