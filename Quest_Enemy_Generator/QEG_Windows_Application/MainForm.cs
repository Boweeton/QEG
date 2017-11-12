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

        readonly List<Glyph> currentGlyphSearchResults = new List<Glyph>();

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
        void SearchGlyphs()
        {
            // Clear the list
            currentGlyphSearchResults.Clear();

            // Local declarations
            string searchParam1 = glyphSearchInputBox1.Text.ToLower();
            string searchParam2 = glyphSearchInputBox2.Text.ToLower();
            GlyphSearchType searchType1 = (GlyphSearchType)glyphSearchTypeBox1.SelectedIndex;
            GlyphSearchType searchType2 = (GlyphSearchType)glyphSearchTypeBox2.SelectedIndex;

            // Check to see if searchParam == ""
            if (searchParam1 == string.Empty && searchParam2 == string.Empty)
            {
                searchResultsLabel.Text = string.Empty;
                glyphSearchResultsTable.Enabled = false;
                return;
            }

            // Define what constitutes a "matched" glyph
            // Func<Glyph, bool> match1 = FindMatch(searchType1);
            Func<Glyph, bool> match;
            // If both params are filled
            if (searchParam1 != string.Empty && searchParam2 != string.Empty)
            {
                match = glyph => FindMatch(searchType1)(glyph, searchParam1) && FindMatch(searchType2)(glyph, searchParam2);
            }
            // If only param1 is filled
            else if (searchParam1 != string.Empty)
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
                    currentGlyphSearchResults.Add(currentGlyph);
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
            glyphSearchResultsTable.Enabled = true;
        }

        void UpdateGlyphResultsLabel(string param1, string param2, GlyphSearchType type1, GlyphSearchType type2)
        {
            // If both
            if (param1 != string.Empty && param2 != string.Empty)
            {
                searchResultsLabel.Text = $"{currentGlyphSearchResults.Count} results matched \"{param1}\" when searched by {type1} and \"{param2}\" when searched by {type2}";
            }

            // If only box 1
            else if (param1 != string.Empty)
            {
                searchResultsLabel.Text = $"{currentGlyphSearchResults.Count} results matched \"{param1}\" when searched by {type1}";
            }

            // If only box 2
            else
            {
                searchResultsLabel.Text = $"{currentGlyphSearchResults.Count} results matched \"{param2}\" when searched by {type2}";
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
            dm.FillEnemyList(avgLvl, count);

            UpdateAndDisplayToOutput();

            // Make the save buttone active once the output box has been populated at least once
            if (output.Text.Length != 0)
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

        void OnMainFormLoad(object sender, EventArgs e)
        {
            // Auto set the Narrow Class
            for (int i = 0; i < gameClassNorowerBox.Items.Count; i++)
            {
                gameClassNorowerBox.SetItemCheckState(i, CheckState.Checked);
            }

            // Set the focus on to the avgPlrLvl box
            avgPlrLvlBox.Select();
            avgPlrLvlBox.SelectAll();

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

        void OnGlyphSearchInputBoxTextChange(object sender, EventArgs e)
        {
            SearchGlyphs();
        }

        #endregion
    }
}