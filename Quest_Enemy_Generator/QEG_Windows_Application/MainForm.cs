using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        List<Glyph> gSearchResults = new List<Glyph>();

        List<RichTextBox> glyphBoxen = new List<RichTextBox>();

        const int MinSearchLength = 3;
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
                        case Keys.T:
                            ResetGSearch(sender, args);
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
            gSearchResultBox.Enabled = true;

            // Local declarations
            string searchParam1 = glyphSearchInputBox1.Text.ToLower();
            string searchParam2 = glyphSearchInputBox2.Text.ToLower();
            GlyphSearchType searchType1 = (GlyphSearchType)glyphSearchTypeBox1.SelectedIndex;
            GlyphSearchType searchType2 = (GlyphSearchType)glyphSearchTypeBox2.SelectedIndex;

            // Check to see if searchParams are the right size glyphSearchTypeBox1.SelectedIndex != (int)GlyphSearchType.Level
            if (searchParam1.Length < MinSearchLength && searchParam2.Length < MinSearchLength)
            {
                searchResultsLabel.Text = string.Empty;
                gSearchResultBox.Enabled = false;
                gSearchResultBox.Visible = false;
                return;
            }
            gSearchResultBox.Visible = true;
            gSearchResultBox.BackColor = Color.White;

            // Define what constitutes a "matched" glyph
            Func<Glyph, bool> match;
            // If both params are filled
            if ((searchParam1.Length >= MinSearchLength && searchParam2.Length >= MinSearchLength) ||
                (searchParam1.Length >= MinSearchLength && glyphSearchTypeBox2.SelectedIndex == (int)GlyphSearchType.Level) ||
                (glyphSearchTypeBox1.SelectedIndex == (int)GlyphSearchType.Level && searchParam2.Length >= MinSearchLength))
            {
                match = glyph => FindMatch(searchType1)(glyph, searchParam1) && FindMatch(searchType2)(glyph, searchParam2);
            }
            // If only param1 is filled
            else if (searchParam1.Length >= MinSearchLength)
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

            DisplayNewGlyphResults(searchParam1, searchParam2, searchType1, searchType2);
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

        void DisplayNewGlyphResults(string param1, string param2, GlyphSearchType type1, GlyphSearchType type2)
        {
            // Front end printing & calculations
            const float FWidth = 8.3f;
            int partitionLength = (int)(gSearchResultBox.Width / FWidth);
            gSearchResultBox.Clear();

            // Print first partition if there are results
            if (gSearchResults.Count > 0)
            {
                gSearchResultBox.AppendText(new StringBuilder().Append('_', partitionLength).ToString());
                gSearchResultBox.AppendText("\n");
            }

            // Sort before display
            switch (gSearchResultsSortBox.SelectedIndex)
            {
                case 0:
                    gSearchResults = gSearchResults.OrderBy(glyph => glyph.Name).ToList();
                    break;
                case 1:
                    gSearchResults = gSearchResults.OrderByDescending(glyph => glyph.Name).ToList();
                    break;
                case 2:
                    gSearchResults = gSearchResults.OrderByDescending(glyph => glyph.LvlReq).ToList();
                    break;
                case 3:
                    gSearchResults = gSearchResults.OrderBy(glyph => glyph.LvlReq).ToList();
                    break;
                case 4:
                    gSearchResults = gSearchResults.OrderByDescending(glyph => glyph.Speed).ToList();
                    break;
                case 5:
                    gSearchResults = gSearchResults.OrderBy(glyph => glyph.Speed).ToList();
                    break;
            }

            // MASTER LOOP FOR PRINTING AND HIGHLIGHTING
            foreach (Glyph glyph in gSearchResults)
            {
                // Print the Name heder
                gSearchResultBox.AppendText("Name: ");
                PrintAndHighlightIfNeeded(glyph.Name, param1, param2, GlyphSearchType.Name);
                gSearchResultBox.AppendText("\n");

                // Print the school heder
                gSearchResultBox.AppendText("School: ");
                PrintAndHighlightIfNeeded(glyph.School.ToString(), param1, param2, GlyphSearchType.School);
                gSearchResultBox.AppendText("\n");

                // Print the level heder
                gSearchResultBox.AppendText("Lvl: ");
                PrintAndHighlightIfNeeded(glyph.LvlReq.ToString(), param1, param2, GlyphSearchType.Level);
                gSearchResultBox.AppendText("\n");

                // Print the speed heder
                gSearchResultBox.AppendText("SPD: ");
                PrintAndHighlightIfNeeded(glyph.Speed.ToString(), param1, param2, GlyphSearchType.School);
                gSearchResultBox.AppendText("\n");

                // Print the description heder
                gSearchResultBox.AppendText("Description: ");
                PrintAndHighlightIfNeeded(glyph.Description, param1, param2, GlyphSearchType.Description);
                gSearchResultBox.AppendText("\n");

                gSearchResultBox.AppendText(new StringBuilder().Append('_', partitionLength).ToString());
                gSearchResultBox.AppendText("\n");
            }

            void PrintAndHighlightIfNeeded(string superString, string subString1, string subString2, GlyphSearchType goodType)
            {
                // Decide string
                string subString;
                if (goodType == type1)
                {
                    subString = subString1;
                }
                if (goodType == type2)
                {
                    subString = subString2;
                }
                else
                {
                    subString = subString1;
                }

                // Set the highlight color
                Color highlightColor1 = Color.SkyBlue;
                Color highlightColor2 = Color.Chartreuse;

                // Record the current index thus far
                int indexThusFar = gSearchResultBox.TextLength;

                // Figure out how many indexes need highlighting
                List<int> indexesToHighlight = superString.ToLower().AllIndexesOf(subString);

                // Print it
                gSearchResultBox.AppendText(superString);

                // Check to see if we should highlight
                if ((type1 == GlyphSearchType.Anything || type1 == goodType) && subString == param1 && (param1.Length >= MinSearchLength || goodType == GlyphSearchType.Level))
                {
                    foreach (int index in indexesToHighlight)
                    {
                        gSearchResultBox.Select(index + indexThusFar, subString.Length);
                        gSearchResultBox.SelectionBackColor = highlightColor1;
                    }
                }
                if ((type2 == GlyphSearchType.Anything || type2 == goodType) && subString == param2 && (param2.Length >= MinSearchLength || goodType == GlyphSearchType.Level))
                {
                    foreach (int index in indexesToHighlight)
                    {
                        gSearchResultBox.Select(index + indexThusFar, subString.Length);
                        gSearchResultBox.SelectionBackColor = highlightColor2;
                    }
                }
            }

        }

        void UpdateGlyphResultsLabel(string param1, string param2, GlyphSearchType type1, GlyphSearchType type2)
        {
            // If both
            if (param1.Length >= MinSearchLength && param2.Length >= MinSearchLength)
            {
                searchResultsLabel.Text = $"{gSearchResults.Count} results matched \"{param1}\" in {type1} and \"{param2}\" in {type2}";
            }

            // If only box 1
            else if (param1.Length >= MinSearchLength)
            {
                searchResultsLabel.Text = $"{gSearchResults.Count} results matched \"{param1}\" in {type1}";
            }

            // If only box 2
            else if (param2.Length >= MinSearchLength)
            {
                searchResultsLabel.Text = $"{gSearchResults.Count} results matched \"{param2}\" in {type2}";
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

            saveButton.Enabled = true;
            eGenOutput.Enabled = true;
            eGenOutput.BackColor = Color.White;
        }

        void UpdateAndDisplayToOutput()
        {
            // Formatting Options
            dm.PrintWeaponsFull = displayFullWeapons.Checked;
            dm.PrintGlyphsFull = displayFullGlyphs.Checked;
            dm.PrintArmorFull = displayFullArmor.Checked;

            List<string> printList = dm.FormatListForDisplay();

            eGenOutput.Clear();

            string printingString = string.Join(Environment.NewLine, printList);

            eGenOutput.AppendText(printingString);

            // Scroll to top of output box
            eGenOutput.SelectionStart = 0;
            eGenOutput.SelectionLength = 1;
            eGenOutput.ScrollToCaret();
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
            gSearchResultsSortBox.SelectedIndex = 0;

            // Set Values for weapon search
            weaponSearchTypeComboBox.SelectedIndex = 0;
            weaponSearchResultsLabel.Text = string.Empty;
        }

        void OnAvgPlrLvlBoxClick(object sender, EventArgs e)
        {
            avgPlrLvlBox.Select(0,avgPlrLvlBox.Text.Length);
        }

        void enemyCountBox_ValueChanged(object sender, EventArgs e)
        {
            enemyCountBox.Select(0,enemyCountBox.Text.Length);
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
            if (glyphSearchInputBox1.TextLength >= MinSearchLength || gBox1PrevLength >= MinSearchLength || glyphSearchTypeBox1.SelectedIndex == (int)GlyphSearchType.Level)
            {
                SearchGlyphs();
            }
            gBox1PrevLength = glyphSearchInputBox1.TextLength;
        }

        void OnGlyphSearchInputBox2TextChanged(object sender, EventArgs e)
        {
            if (glyphSearchInputBox2.TextLength >= MinSearchLength || gBox2PrevLength >= MinSearchLength || glyphSearchTypeBox2.SelectedIndex == (int)GlyphSearchType.Level)
            {
                SearchGlyphs();
            }
            gBox2PrevLength = glyphSearchInputBox2.TextLength;
        }

        void OnGlyphSearchSortTypeChanged(object sender, EventArgs e)
        {
            OnGlyphSearchInputBox1TextChanged(sender, e);
            OnGlyphSearchInputBox2TextChanged(sender, e);
        }

        void ResetGSearch(object sender, EventArgs e)
        {
            glyphSearchInputBox1.Text = string.Empty;
            glyphSearchInputBox2.Text = string.Empty;
            glyphSearchTypeBox1.SelectedIndex = 0;
            glyphSearchTypeBox2.SelectedIndex = 0;
            gSearchResultsSortBox.SelectedIndex = 0;
        }

        void OnEGClearButtonClick(object sender, EventArgs e)
        {
            avgPlrLvlBox.Value = 1;
            enemyCountBox.Value = 1;
            displayFullWeapons.Checked = false;
            displayFullGlyphs.Checked = false;
            displayFullArmor.Checked = false;
            randomModes.SelectedIndex = 0;
            gameClassNorowerBox.SelectedIndex = 0;
            eGenOutput.Text = string.Empty;
            eGenOutput.Enabled = false;
            saveButton.Enabled = false;
        }

        #endregion
    }
}