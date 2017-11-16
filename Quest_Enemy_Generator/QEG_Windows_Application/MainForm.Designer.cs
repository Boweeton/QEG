namespace QEG_Windows_Application
{
    partial class QegForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QegForm));
            this.displayFullWeapons = new System.Windows.Forms.CheckBox();
            this.displayFullGlyphs = new System.Windows.Forms.CheckBox();
            this.displayFullArmor = new System.Windows.Forms.CheckBox();
            this.avgPlrLvlLabel = new System.Windows.Forms.Label();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.enemyCountLabel = new System.Windows.Forms.Label();
            this.eGenOutput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.formatOptions = new System.Windows.Forms.GroupBox();
            this.inputData = new System.Windows.Forms.GroupBox();
            this.enemyCountBox = new System.Windows.Forms.NumericUpDown();
            this.avgPlrLvlBox = new System.Windows.Forms.NumericUpDown();
            this.randomModes = new System.Windows.Forms.ListBox();
            this.randomMode = new System.Windows.Forms.GroupBox();
            this.saveFileToTxtDialog = new System.Windows.Forms.SaveFileDialog();
            this.gameClassNarowingGroupBox = new System.Windows.Forms.GroupBox();
            this.gameClassNorowerBox = new System.Windows.Forms.CheckedListBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playerTrackerTabTab = new System.Windows.Forms.TabPage();
            this.gsPlannerTab = new System.Windows.Forms.TabPage();
            this.enemyGenerationTab = new System.Windows.Forms.TabPage();
            this.eGResetButton = new System.Windows.Forms.Button();
            this.glyphSearchTab = new System.Windows.Forms.TabPage();
            this.gSearchResetButton = new System.Windows.Forms.Button();
            this.gSortGroupBox = new System.Windows.Forms.GroupBox();
            this.gSearchResultsSortBox = new System.Windows.Forms.ComboBox();
            this.gSearchParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.glyphSearchInputBox1 = new System.Windows.Forms.TextBox();
            this.glyphSearchInputBox2 = new System.Windows.Forms.TextBox();
            this.glyphSearchTypeBox1 = new System.Windows.Forms.ComboBox();
            this.glyphSearchTypeBox2 = new System.Windows.Forms.ComboBox();
            this.gSearchResultBox = new System.Windows.Forms.RichTextBox();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.weaponSearchTab = new System.Windows.Forms.TabPage();
            this.areaGeneratorTab = new System.Windows.Forms.TabPage();
            this.npcGeneratorTab = new System.Windows.Forms.TabPage();
            this.formatOptions.SuspendLayout();
            this.inputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgPlrLvlBox)).BeginInit();
            this.randomMode.SuspendLayout();
            this.gameClassNarowingGroupBox.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.enemyGenerationTab.SuspendLayout();
            this.glyphSearchTab.SuspendLayout();
            this.gSortGroupBox.SuspendLayout();
            this.gSearchParamsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayFullWeapons
            // 
            this.displayFullWeapons.AutoSize = true;
            this.displayFullWeapons.Location = new System.Drawing.Point(5, 21);
            this.displayFullWeapons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayFullWeapons.Name = "displayFullWeapons";
            this.displayFullWeapons.Size = new System.Drawing.Size(158, 21);
            this.displayFullWeapons.TabIndex = 0;
            this.displayFullWeapons.Text = "Display full weapons";
            this.displayFullWeapons.UseVisualStyleBackColor = true;
            this.displayFullWeapons.CheckedChanged += new System.EventHandler(this.OnDisplayWeaponsChanged);
            // 
            // displayFullGlyphs
            // 
            this.displayFullGlyphs.AutoSize = true;
            this.displayFullGlyphs.Location = new System.Drawing.Point(5, 48);
            this.displayFullGlyphs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayFullGlyphs.Name = "displayFullGlyphs";
            this.displayFullGlyphs.Size = new System.Drawing.Size(143, 21);
            this.displayFullGlyphs.TabIndex = 1;
            this.displayFullGlyphs.Text = "Display full glyphs";
            this.displayFullGlyphs.UseVisualStyleBackColor = true;
            this.displayFullGlyphs.CheckedChanged += new System.EventHandler(this.OnDisplayFullGlyphsChanged);
            // 
            // displayFullArmor
            // 
            this.displayFullArmor.AutoSize = true;
            this.displayFullArmor.Location = new System.Drawing.Point(5, 75);
            this.displayFullArmor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayFullArmor.Name = "displayFullArmor";
            this.displayFullArmor.Size = new System.Drawing.Size(139, 21);
            this.displayFullArmor.TabIndex = 2;
            this.displayFullArmor.Text = "Display full armor";
            this.displayFullArmor.UseVisualStyleBackColor = true;
            this.displayFullArmor.CheckedChanged += new System.EventHandler(this.OnDisplayFullArmorChanged);
            // 
            // avgPlrLvlLabel
            // 
            this.avgPlrLvlLabel.AutoSize = true;
            this.avgPlrLvlLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.avgPlrLvlLabel.Location = new System.Drawing.Point(7, 18);
            this.avgPlrLvlLabel.Name = "avgPlrLvlLabel";
            this.avgPlrLvlLabel.Size = new System.Drawing.Size(99, 17);
            this.avgPlrLvlLabel.TabIndex = 4;
            this.avgPlrLvlLabel.Text = "Average Level";
            this.avgPlrLvlLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // randomizeButton
            // 
            this.randomizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeButton.Location = new System.Drawing.Point(379, 12);
            this.randomizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(200, 39);
            this.randomizeButton.TabIndex = 1;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.OnRandomizeClicked);
            // 
            // enemyCountLabel
            // 
            this.enemyCountLabel.AutoSize = true;
            this.enemyCountLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enemyCountLabel.Location = new System.Drawing.Point(11, 63);
            this.enemyCountLabel.Name = "enemyCountLabel";
            this.enemyCountLabel.Size = new System.Drawing.Size(92, 17);
            this.enemyCountLabel.TabIndex = 2;
            this.enemyCountLabel.Text = "Enemy Count";
            this.enemyCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // eGenOutput
            // 
            this.eGenOutput.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eGenOutput.Location = new System.Drawing.Point(5, 176);
            this.eGenOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eGenOutput.Multiline = true;
            this.eGenOutput.Name = "eGenOutput";
            this.eGenOutput.ReadOnly = true;
            this.eGenOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eGenOutput.Size = new System.Drawing.Size(932, 611);
            this.eGenOutput.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(379, 57);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 39);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnPrintButtonClicked);
            // 
            // formatOptions
            // 
            this.formatOptions.Controls.Add(this.displayFullWeapons);
            this.formatOptions.Controls.Add(this.displayFullGlyphs);
            this.formatOptions.Controls.Add(this.displayFullArmor);
            this.formatOptions.Location = new System.Drawing.Point(128, 5);
            this.formatOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formatOptions.Name = "formatOptions";
            this.formatOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formatOptions.Size = new System.Drawing.Size(169, 102);
            this.formatOptions.TabIndex = 10;
            this.formatOptions.TabStop = false;
            this.formatOptions.Text = "Formatting Options";
            // 
            // inputData
            // 
            this.inputData.Controls.Add(this.enemyCountBox);
            this.inputData.Controls.Add(this.avgPlrLvlLabel);
            this.inputData.Controls.Add(this.avgPlrLvlBox);
            this.inputData.Controls.Add(this.enemyCountLabel);
            this.inputData.Location = new System.Drawing.Point(5, 5);
            this.inputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputData.Name = "inputData";
            this.inputData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputData.Size = new System.Drawing.Size(116, 113);
            this.inputData.TabIndex = 0;
            this.inputData.TabStop = false;
            this.inputData.Text = "Input Data";
            // 
            // enemyCountBox
            // 
            this.enemyCountBox.Location = new System.Drawing.Point(8, 82);
            this.enemyCountBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enemyCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enemyCountBox.Name = "enemyCountBox";
            this.enemyCountBox.Size = new System.Drawing.Size(100, 22);
            this.enemyCountBox.TabIndex = 1;
            this.enemyCountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enemyCountBox.ValueChanged += new System.EventHandler(this.enemyCountBox_ValueChanged);
            // 
            // avgPlrLvlBox
            // 
            this.avgPlrLvlBox.Location = new System.Drawing.Point(8, 38);
            this.avgPlrLvlBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avgPlrLvlBox.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.avgPlrLvlBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avgPlrLvlBox.Name = "avgPlrLvlBox";
            this.avgPlrLvlBox.Size = new System.Drawing.Size(100, 22);
            this.avgPlrLvlBox.TabIndex = 0;
            this.avgPlrLvlBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avgPlrLvlBox.Click += new System.EventHandler(this.OnAvgPlrLvlBoxClick);
            // 
            // randomModes
            // 
            this.randomModes.FormattingEnabled = true;
            this.randomModes.ItemHeight = 16;
            this.randomModes.Items.AddRange(new object[] {
            "Normal mode",
            "More easy",
            "More medium",
            "More hard",
            "All easy",
            "All medium",
            "All hard"});
            this.randomModes.Location = new System.Drawing.Point(13, 21);
            this.randomModes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomModes.Name = "randomModes";
            this.randomModes.Size = new System.Drawing.Size(95, 116);
            this.randomModes.TabIndex = 12;
            // 
            // randomMode
            // 
            this.randomMode.Controls.Add(this.randomModes);
            this.randomMode.Location = new System.Drawing.Point(639, 6);
            this.randomMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomMode.Name = "randomMode";
            this.randomMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomMode.Size = new System.Drawing.Size(124, 148);
            this.randomMode.TabIndex = 13;
            this.randomMode.TabStop = false;
            this.randomMode.Text = "Random Mode";
            // 
            // saveFileToTxtDialog
            // 
            this.saveFileToTxtDialog.DefaultExt = "txt";
            this.saveFileToTxtDialog.FileName = "QEG_Save";
            // 
            // gameClassNarowingGroupBox
            // 
            this.gameClassNarowingGroupBox.Controls.Add(this.gameClassNorowerBox);
            this.gameClassNarowingGroupBox.Location = new System.Drawing.Point(769, 6);
            this.gameClassNarowingGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameClassNarowingGroupBox.Name = "gameClassNarowingGroupBox";
            this.gameClassNarowingGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameClassNarowingGroupBox.Size = new System.Drawing.Size(169, 148);
            this.gameClassNarowingGroupBox.TabIndex = 15;
            this.gameClassNarowingGroupBox.TabStop = false;
            this.gameClassNarowingGroupBox.Text = "Narrow Class";
            // 
            // gameClassNorowerBox
            // 
            this.gameClassNorowerBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameClassNorowerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameClassNorowerBox.ColumnWidth = 10;
            this.gameClassNorowerBox.FormattingEnabled = true;
            this.gameClassNorowerBox.Items.AddRange(new object[] {
            "Heavy Fighters",
            "Light Fighters",
            "Sneak Fighters",
            "Heavy Magic Users",
            "Light Magic Users"});
            this.gameClassNorowerBox.Location = new System.Drawing.Point(5, 18);
            this.gameClassNorowerBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameClassNorowerBox.Name = "gameClassNorowerBox";
            this.gameClassNorowerBox.Size = new System.Drawing.Size(155, 102);
            this.gameClassNorowerBox.TabIndex = 16;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playerTrackerTabTab);
            this.mainTabControl.Controls.Add(this.gsPlannerTab);
            this.mainTabControl.Controls.Add(this.enemyGenerationTab);
            this.mainTabControl.Controls.Add(this.glyphSearchTab);
            this.mainTabControl.Controls.Add(this.weaponSearchTab);
            this.mainTabControl.Controls.Add(this.areaGeneratorTab);
            this.mainTabControl.Controls.Add(this.npcGeneratorTab);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(955, 821);
            this.mainTabControl.TabIndex = 0;
            // 
            // playerTrackerTabTab
            // 
            this.playerTrackerTabTab.BackColor = System.Drawing.SystemColors.Control;
            this.playerTrackerTabTab.Location = new System.Drawing.Point(4, 25);
            this.playerTrackerTabTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerTrackerTabTab.Name = "playerTrackerTabTab";
            this.playerTrackerTabTab.Size = new System.Drawing.Size(947, 792);
            this.playerTrackerTabTab.TabIndex = 6;
            this.playerTrackerTabTab.Text = "Player Tracker";
            // 
            // gsPlannerTab
            // 
            this.gsPlannerTab.BackColor = System.Drawing.SystemColors.Control;
            this.gsPlannerTab.Location = new System.Drawing.Point(4, 25);
            this.gsPlannerTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gsPlannerTab.Name = "gsPlannerTab";
            this.gsPlannerTab.Size = new System.Drawing.Size(947, 792);
            this.gsPlannerTab.TabIndex = 5;
            this.gsPlannerTab.Text = "GS Planner";
            // 
            // enemyGenerationTab
            // 
            this.enemyGenerationTab.BackColor = System.Drawing.Color.Transparent;
            this.enemyGenerationTab.Controls.Add(this.eGResetButton);
            this.enemyGenerationTab.Controls.Add(this.inputData);
            this.enemyGenerationTab.Controls.Add(this.eGenOutput);
            this.enemyGenerationTab.Controls.Add(this.randomMode);
            this.enemyGenerationTab.Controls.Add(this.gameClassNarowingGroupBox);
            this.enemyGenerationTab.Controls.Add(this.formatOptions);
            this.enemyGenerationTab.Controls.Add(this.saveButton);
            this.enemyGenerationTab.Controls.Add(this.randomizeButton);
            this.enemyGenerationTab.Location = new System.Drawing.Point(4, 25);
            this.enemyGenerationTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyGenerationTab.Name = "enemyGenerationTab";
            this.enemyGenerationTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyGenerationTab.Size = new System.Drawing.Size(947, 792);
            this.enemyGenerationTab.TabIndex = 0;
            this.enemyGenerationTab.Text = "Enemy Generation";
            // 
            // eGResetButton
            // 
            this.eGResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eGResetButton.Location = new System.Drawing.Point(379, 105);
            this.eGResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eGResetButton.Name = "eGResetButton";
            this.eGResetButton.Size = new System.Drawing.Size(200, 39);
            this.eGResetButton.TabIndex = 16;
            this.eGResetButton.Text = "Clear";
            this.eGResetButton.UseVisualStyleBackColor = true;
            this.eGResetButton.Click += new System.EventHandler(this.OnEGClearButtonClick);
            // 
            // glyphSearchTab
            // 
            this.glyphSearchTab.BackColor = System.Drawing.Color.Transparent;
            this.glyphSearchTab.Controls.Add(this.gSearchResetButton);
            this.glyphSearchTab.Controls.Add(this.gSortGroupBox);
            this.glyphSearchTab.Controls.Add(this.gSearchParamsGroupBox);
            this.glyphSearchTab.Controls.Add(this.gSearchResultBox);
            this.glyphSearchTab.Controls.Add(this.searchResultsLabel);
            this.glyphSearchTab.Location = new System.Drawing.Point(4, 25);
            this.glyphSearchTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glyphSearchTab.Name = "glyphSearchTab";
            this.glyphSearchTab.Size = new System.Drawing.Size(947, 792);
            this.glyphSearchTab.TabIndex = 2;
            this.glyphSearchTab.Text = "Glyph Search";
            // 
            // gSearchResetButton
            // 
            this.gSearchResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gSearchResetButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gSearchResetButton.Location = new System.Drawing.Point(795, 129);
            this.gSearchResetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSearchResetButton.Name = "gSearchResetButton";
            this.gSearchResetButton.Size = new System.Drawing.Size(128, 43);
            this.gSearchResetButton.TabIndex = 8;
            this.gSearchResetButton.Text = "Reset";
            this.gSearchResetButton.UseVisualStyleBackColor = true;
            this.gSearchResetButton.Click += new System.EventHandler(this.ResetGSearch);
            // 
            // gSortGroupBox
            // 
            this.gSortGroupBox.Controls.Add(this.gSearchResultsSortBox);
            this.gSortGroupBox.Location = new System.Drawing.Point(21, 108);
            this.gSortGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSortGroupBox.Name = "gSortGroupBox";
            this.gSortGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSortGroupBox.Size = new System.Drawing.Size(251, 64);
            this.gSortGroupBox.TabIndex = 7;
            this.gSortGroupBox.TabStop = false;
            this.gSortGroupBox.Text = "Sort";
            // 
            // gSearchResultsSortBox
            // 
            this.gSearchResultsSortBox.FormattingEnabled = true;
            this.gSearchResultsSortBox.Items.AddRange(new object[] {
            "Sort by Name (A-Z)",
            "Sort by Name (Z-A)",
            "Sort by Level (Greatest - Least)",
            "Sort by Level (Least - Greatest)",
            "Sort by Speed (Greatest - Least)",
            "Sort by Speed (Least - Greatest)"});
            this.gSearchResultsSortBox.Location = new System.Drawing.Point(8, 23);
            this.gSearchResultsSortBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSearchResultsSortBox.Name = "gSearchResultsSortBox";
            this.gSearchResultsSortBox.Size = new System.Drawing.Size(229, 24);
            this.gSearchResultsSortBox.TabIndex = 0;
            this.gSearchResultsSortBox.SelectedIndexChanged += new System.EventHandler(this.OnGlyphSearchSortTypeChanged);
            // 
            // gSearchParamsGroupBox
            // 
            this.gSearchParamsGroupBox.Controls.Add(this.glyphSearchInputBox1);
            this.gSearchParamsGroupBox.Controls.Add(this.glyphSearchInputBox2);
            this.gSearchParamsGroupBox.Controls.Add(this.glyphSearchTypeBox1);
            this.gSearchParamsGroupBox.Controls.Add(this.glyphSearchTypeBox2);
            this.gSearchParamsGroupBox.Location = new System.Drawing.Point(21, 4);
            this.gSearchParamsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSearchParamsGroupBox.Name = "gSearchParamsGroupBox";
            this.gSearchParamsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSearchParamsGroupBox.Size = new System.Drawing.Size(901, 97);
            this.gSearchParamsGroupBox.TabIndex = 6;
            this.gSearchParamsGroupBox.TabStop = false;
            this.gSearchParamsGroupBox.Text = "Search";
            // 
            // glyphSearchInputBox1
            // 
            this.glyphSearchInputBox1.Location = new System.Drawing.Point(8, 23);
            this.glyphSearchInputBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glyphSearchInputBox1.Name = "glyphSearchInputBox1";
            this.glyphSearchInputBox1.Size = new System.Drawing.Size(623, 22);
            this.glyphSearchInputBox1.TabIndex = 1;
            this.glyphSearchInputBox1.TextChanged += new System.EventHandler(this.OnGlyphSearchInputBox1TextChanged);
            // 
            // glyphSearchInputBox2
            // 
            this.glyphSearchInputBox2.Location = new System.Drawing.Point(8, 55);
            this.glyphSearchInputBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glyphSearchInputBox2.Name = "glyphSearchInputBox2";
            this.glyphSearchInputBox2.Size = new System.Drawing.Size(623, 22);
            this.glyphSearchInputBox2.TabIndex = 2;
            this.glyphSearchInputBox2.TextChanged += new System.EventHandler(this.OnGlyphSearchInputBox2TextChanged);
            // 
            // glyphSearchTypeBox1
            // 
            this.glyphSearchTypeBox1.FormattingEnabled = true;
            this.glyphSearchTypeBox1.Location = new System.Drawing.Point(663, 22);
            this.glyphSearchTypeBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glyphSearchTypeBox1.Name = "glyphSearchTypeBox1";
            this.glyphSearchTypeBox1.Size = new System.Drawing.Size(229, 24);
            this.glyphSearchTypeBox1.TabIndex = 0;
            this.glyphSearchTypeBox1.SelectedIndexChanged += new System.EventHandler(this.OnGlyphSearchTypeChanged);
            // 
            // glyphSearchTypeBox2
            // 
            this.glyphSearchTypeBox2.FormattingEnabled = true;
            this.glyphSearchTypeBox2.Location = new System.Drawing.Point(663, 54);
            this.glyphSearchTypeBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glyphSearchTypeBox2.Name = "glyphSearchTypeBox2";
            this.glyphSearchTypeBox2.Size = new System.Drawing.Size(229, 24);
            this.glyphSearchTypeBox2.TabIndex = 0;
            this.glyphSearchTypeBox2.SelectedIndexChanged += new System.EventHandler(this.OnGlyphSearchTypeChanged);
            // 
            // gSearchResultBox
            // 
            this.gSearchResultBox.BackColor = System.Drawing.SystemColors.Window;
            this.gSearchResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gSearchResultBox.Location = new System.Drawing.Point(21, 201);
            this.gSearchResultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gSearchResultBox.Name = "gSearchResultBox";
            this.gSearchResultBox.ReadOnly = true;
            this.gSearchResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.gSearchResultBox.Size = new System.Drawing.Size(900, 571);
            this.gSearchResultBox.TabIndex = 5;
            this.gSearchResultBox.Text = "";
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.Location = new System.Drawing.Point(17, 176);
            this.searchResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(64, 24);
            this.searchResultsLabel.TabIndex = 4;
            this.searchResultsLabel.Text = "results";
            // 
            // weaponSearchTab
            // 
            this.weaponSearchTab.BackColor = System.Drawing.Color.Transparent;
            this.weaponSearchTab.Location = new System.Drawing.Point(4, 25);
            this.weaponSearchTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weaponSearchTab.Name = "weaponSearchTab";
            this.weaponSearchTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weaponSearchTab.Size = new System.Drawing.Size(947, 792);
            this.weaponSearchTab.TabIndex = 1;
            this.weaponSearchTab.Text = "Weapon Search";
            // 
            // areaGeneratorTab
            // 
            this.areaGeneratorTab.BackColor = System.Drawing.SystemColors.Control;
            this.areaGeneratorTab.Location = new System.Drawing.Point(4, 25);
            this.areaGeneratorTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.areaGeneratorTab.Name = "areaGeneratorTab";
            this.areaGeneratorTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.areaGeneratorTab.Size = new System.Drawing.Size(947, 792);
            this.areaGeneratorTab.TabIndex = 3;
            this.areaGeneratorTab.Text = "Area Generator";
            // 
            // npcGeneratorTab
            // 
            this.npcGeneratorTab.BackColor = System.Drawing.SystemColors.Control;
            this.npcGeneratorTab.Location = new System.Drawing.Point(4, 25);
            this.npcGeneratorTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npcGeneratorTab.Name = "npcGeneratorTab";
            this.npcGeneratorTab.Size = new System.Drawing.Size(947, 792);
            this.npcGeneratorTab.TabIndex = 4;
            this.npcGeneratorTab.Text = "NPC Generator";
            // 
            // QegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(979, 846);
            this.Controls.Add(this.mainTabControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "QegForm";
            this.Text = "GM Toolbox 1.0";
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.formatOptions.ResumeLayout(false);
            this.formatOptions.PerformLayout();
            this.inputData.ResumeLayout(false);
            this.inputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgPlrLvlBox)).EndInit();
            this.randomMode.ResumeLayout(false);
            this.gameClassNarowingGroupBox.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.enemyGenerationTab.ResumeLayout(false);
            this.enemyGenerationTab.PerformLayout();
            this.glyphSearchTab.ResumeLayout(false);
            this.glyphSearchTab.PerformLayout();
            this.gSortGroupBox.ResumeLayout(false);
            this.gSearchParamsGroupBox.ResumeLayout(false);
            this.gSearchParamsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox displayFullWeapons;
        private System.Windows.Forms.CheckBox displayFullGlyphs;
        private System.Windows.Forms.CheckBox displayFullArmor;
        private System.Windows.Forms.Label avgPlrLvlLabel;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.Label enemyCountLabel;
        private System.Windows.Forms.TextBox eGenOutput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox formatOptions;
        private System.Windows.Forms.GroupBox inputData;
        private System.Windows.Forms.ListBox randomModes;
        private System.Windows.Forms.GroupBox randomMode;
        private System.Windows.Forms.SaveFileDialog saveFileToTxtDialog;
        private System.Windows.Forms.GroupBox gameClassNarowingGroupBox;
        private System.Windows.Forms.CheckedListBox gameClassNorowerBox;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage enemyGenerationTab;
        private System.Windows.Forms.TabPage weaponSearchTab;
        private System.Windows.Forms.TabPage glyphSearchTab;
        private System.Windows.Forms.ComboBox glyphSearchTypeBox1;
        private System.Windows.Forms.TextBox glyphSearchInputBox1;
        private System.Windows.Forms.ComboBox glyphSearchTypeBox2;
        private System.Windows.Forms.TextBox glyphSearchInputBox2;
        private System.Windows.Forms.Label searchResultsLabel;
        private System.Windows.Forms.NumericUpDown enemyCountBox;
        private System.Windows.Forms.NumericUpDown avgPlrLvlBox;
        private System.Windows.Forms.RichTextBox gSearchResultBox;
        private System.Windows.Forms.ComboBox gSearchResultsSortBox;
        private System.Windows.Forms.GroupBox gSortGroupBox;
        private System.Windows.Forms.GroupBox gSearchParamsGroupBox;
        private System.Windows.Forms.Button gSearchResetButton;
        private System.Windows.Forms.TabPage areaGeneratorTab;
        private System.Windows.Forms.TabPage npcGeneratorTab;
        private System.Windows.Forms.TabPage gsPlannerTab;
        private System.Windows.Forms.TabPage playerTrackerTabTab;
        private System.Windows.Forms.Button eGResetButton;
    }
}

