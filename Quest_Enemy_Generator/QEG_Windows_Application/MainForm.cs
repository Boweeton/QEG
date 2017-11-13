using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QEG_Classes;
using Quest_Enemy_Generator;

namespace QEG_Windows_Application
{
    public partial class QegForm : Form
    {
        #region Data

        // == DATA ==
        readonly DataManager dm = new DataManager();

        readonly List<Glyph> gSearchResults = new List<Glyph>();

        List<RichTextBox> glyphBoxen = new List<RichTextBox>();

        const int minSearchLength = 2;
        int gBox1PrevLength;
        int gBox2PrevLength;

        #endregion

        #region Constructors

        // == CONSTRUCTORS ==
        public QegForm()
        {
            InitializeComponent();
            randomModes.SelectedIndex = 0;

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

            avgPlrLvlBox.Click += (sender, args) => avgPlrLvlBox.Select();
            enemyCountBox.Click += (sender, args) => enemyCountBox.Select();

            //avgPlrLvlBox.Enter += (sender, args) => avgPlrLvlBox.Select(0,avgPlrLvlBox.TextLength);
            //enemyCountBox.Enter += (sender, args) => enemyCountBox.Select(0,enemyCountBox.TextLength);

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
        void SearchGlyphs()
        {
            // Clear the list
            gSearchResults.Clear();

            // Local declarations
            string searchParam1 = glyphSearchInputBox1.Text.ToLower();
            string searchParam2 = glyphSearchInputBox2.Text.ToLower();
            GlyphSearchType searchType1 = (GlyphSearchType)glyphSearchTypeBox1.SelectedIndex;
            GlyphSearchType searchType2 = (GlyphSearchType)glyphSearchTypeBox2.SelectedIndex;

            // Check to see if searchParams are the right size glyphSearchTypeBox1.SelectedIndex != (int)GlyphSearchType.Level
            if ((searchParam1.Length < minSearchLength && searchParam2.Length < minSearchLength) ||
                (glyphSearchTypeBox1.SelectedIndex == (int)GlyphSearchType.Level && searchParam2.Length < minSearchLength) ||
                (glyphSearchTypeBox2.SelectedIndex == (int)GlyphSearchType.Level && searchParam1.Length < minSearchLength))
            {
                searchResultsLabel.Text = string.Empty;
                glyphResultsTable.Enabled = false;
                glyphResultsTable.Visible = false;
                return;
            }
            glyphResultsTable.Visible = true;

            // Define what constitutes a "matched" glyph
            Func<Glyph, bool> match;
            // If both params are filled
            if ((searchParam1.Length >= minSearchLength && searchParam2.Length >= minSearchLength) ||
                (glyphSearchTypeBox1.SelectedIndex == (int)GlyphSearchType.Level && searchParam2.Length >= minSearchLength) ||
                (glyphSearchTypeBox2.SelectedIndex == (int)GlyphSearchType.Level && searchParam1.Length >= minSearchLength))
            {
                match = glyph => FindMatch(searchType1)(glyph, searchParam1) && FindMatch(searchType2)(glyph, searchParam2);
            }
            // If only param1 is filled
            else if (searchParam1.Length >= minSearchLength || glyphSearchTypeBox2.SelectedIndex == (int)GlyphSearchType.Level)
            {
                match = glyph => FindMatch(searchType1)(glyph, searchParam1);
            }
            // If only param2 is filled
            else
            {
                match = glyph => FindMatch(searchType2)(glyph, searchParam2);
            }

            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach (Glyph currentGlyph in dm.Glyphs)
            {
                if (match(currentGlyph))
                {
                    gSearchResults.Add(currentGlyph);
                }
            }

            DisplayNewGlyphResults();
            UpdateGlyphResultsLabel(searchParam1, searchParam2, searchType1, searchType2);

            // Locally defined functions
            bool AnythingTest(Glyph g, string param) => NameTest(g, param) || TypeTest(g, param) || LevelTest(g, param) || DescriptionTest(g, param);

            bool NameTest(Glyph g, string param) => g.Name.ToLower().Contains(param);

            bool TypeTest(Glyph g, string param) => g.School.ToString().ToLower().Contains(param);

            bool LevelTest(Glyph g, string param) => g.LvlReq.ToString().ToLower() == param;

            bool DescriptionTest(Glyph g, string param) => g.Description.ToLower().Contains(param);

            Func<Glyph, string, bool> FindMatch(GlyphSearchType type)
            {
                switch (type)
                {
                    case GlyphSearchType.Anything:
                        return AnythingTest;
                    case GlyphSearchType.Name:
                        return NameTest;
                    case GlyphSearchType.School:
                        return TypeTest;
                    case GlyphSearchType.Level:
                        return LevelTest;
                    case GlyphSearchType.Description:
                        return DescriptionTest;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        void DisplayNewGlyphResults()
        {
            glyphResultsTable.Enabled = true;
            glyphResultsTable.RowCount = gSearchResults.Count;

            // Loop through to populate the glyphs
            for (int i = glyphBoxen.Count; i < gSearchResults.Count; i++)
            {
                RichTextBox richard = new RichTextBox { Dock = DockStyle.Fill, ReadOnly = true};
                glyphResultsTable.Controls.Add(richard, 0, i);
                glyphBoxen.Add(richard);
                glyphResultsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            }

            // Loop to remove unwanted boxen
            for (int i = glyphBoxen.Count - 1; i > gSearchResults.Count - 1; i--)
            {
                glyphBoxen.RemoveAt(i);
                glyphResultsTable.Controls.RemoveAt(i);
                glyphResultsTable.RowStyles.RemoveAt(i);
            }

            // Loop to populate boxen
            for (int i = 0; i < glyphBoxen.Count; i++)
            {
                glyphBoxen[i].Text = gSearchResults[i].Name;
                glyphResultsTable.RowStyles[i].Height = glyphBoxen[i].Text.CountLines() * 40;
                glyphBoxen[i].BackColor = Color.White;
                glyphBoxen[i].MouseHover += (sender, args) => glyphResultsTable.Focus();
            }
        }

        void UpdateGlyphResultsLabel(string param1, string param2, GlyphSearchType type1, GlyphSearchType type2)
        {
            // If both
            if (param1.Length >= minSearchLength && param2.Length >= minSearchLength)
            {
                searchResultsLabel.Text = $"{gSearchResults.Count} results matched \"{param1}\" when searched by {type1} and \"{param2}\" when searched by {type2}";
            }

            // If only box 1
            else if (param1.Length >= minSearchLength)
            {
                searchResultsLabel.Text = $"{gSearchResults.Count} results matched \"{param1}\" when searched by {type1}";
            }

            // If only box 2
            else if (param2.Length >= minSearchLength)
            {
                searchResultsLabel.Text = $"{gSearchResults.Count} results matched \"{param2}\" when searched by {type2}";
            }
        }

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
            dm.FillEnemyList((int)avgPlrLvlBox.Value, (int)enemyCountBox.Value);

            UpdateAndDisplayToOutput();

            // Make the save buttone active once the output box has been populated at least once
            if (output.TextLength != 0)
            {
                saveButton.Enabled = true;
                output.BackColor = Color.White;
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

        void OnMainFormLoad(object sender, EventArgs e)
        {
            // Auto set the Narrow Class
            for (int i = 0; i < gameClassNorowerBox.Items.Count; i++)
            {
                gameClassNorowerBox.SetItemCheckState(i, CheckState.Checked);
            }

            // Set the focus on to the avgPlrLvl box
            avgPlrLvlBox.Select();
            avgPlrLvlBox.Select(0,1);

            // Load settings for glyphSearch boxes
            glyphSearchTypeBox1.Items.Clear();
            glyphSearchTypeBox2.Items.Clear();

            foreach (GlyphSearchType searchType in Enum.GetValues(typeof(GlyphSearchType)))
            {
                glyphSearchTypeBox1.Items.Add($"Search by {searchType}");
                glyphSearchTypeBox2.Items.Add($"Search by {searchType}");
            }
            glyphSearchTypeBox1.SelectedIndex = 0;
            glyphSearchTypeBox2.SelectedIndex = 0;

            searchResultsLabel.Text = string.Empty;
        }

        void OnDisplayWeaponsChanged(object sender, EventArgs e)
        {
            if (dm.EnemyList != null)
            {
                UpdateAndDisplayToOutput();
            }
        }

        void OnDisplayFullGlyphsChanged(object sender, EventArgs e)
        {
            if (dm.EnemyList != null)
            {
                UpdateAndDisplayToOutput();
            }
        }

        void OnDisplayFullArmorChanged(object sender, EventArgs e)
        {
            if (dm.EnemyList != null)
            {
                UpdateAndDisplayToOutput();
            }
        }

        void OnRandomizeClicked(object sender, EventArgs e)
        {
            Rando();
        }

        void OnPrintButtonClicked(object sender, EventArgs e)
        {
            SaveToFile();
        }

        void OnGlyphSearchTypeChanged(object sender, EventArgs e)
        {
            SearchGlyphs();
        }

        void OnGlyphSearchInputBox1TextChanged(object sender, EventArgs e)
        {
            if (glyphSearchInputBox1.TextLength >= minSearchLength || gBox1PrevLength >= minSearchLength || glyphSearchTypeBox1.SelectedIndex == (int)GlyphSearchType.Level)
            {
                SearchGlyphs();
            }
            gBox1PrevLength = glyphSearchInputBox1.TextLength;
        }

        void OnGlyphSearchInputBox2TextChanged(object sender, EventArgs e)
        {
            if (glyphSearchInputBox2.TextLength >= minSearchLength || gBox2PrevLength >= minSearchLength || glyphSearchTypeBox2.SelectedIndex == (int)GlyphSearchType.Level)
            {
                SearchGlyphs();
            }
            gBox2PrevLength = glyphSearchInputBox2.TextLength;
        }

        #endregion
    }
}