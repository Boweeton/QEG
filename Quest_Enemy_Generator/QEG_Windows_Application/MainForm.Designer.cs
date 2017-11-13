﻿namespace QEG_Windows_Application
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
            this.output = new System.Windows.Forms.TextBox();
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
            this.enemyGenerationTabPage = new System.Windows.Forms.TabPage();
            this.glyphSearchTabPage = new System.Windows.Forms.TabPage();
            this.gSortGroupBox = new System.Windows.Forms.GroupBox();
            this.gSearchResultsSortBox = new System.Windows.Forms.ComboBox();
            this.gSearchParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.glyphSearchInputBox1 = new System.Windows.Forms.TextBox();
            this.glyphSearchInputBox2 = new System.Windows.Forms.TextBox();
            this.glyphSearchTypeBox1 = new System.Windows.Forms.ComboBox();
            this.glyphSearchTypeBox2 = new System.Windows.Forms.ComboBox();
            this.gSearchResultBox = new System.Windows.Forms.RichTextBox();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.weaponSearchTabPage = new System.Windows.Forms.TabPage();
            this.gSearchResetButton = new System.Windows.Forms.Button();
            this.formatOptions.SuspendLayout();
            this.inputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgPlrLvlBox)).BeginInit();
            this.randomMode.SuspendLayout();
            this.gameClassNarowingGroupBox.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.enemyGenerationTabPage.SuspendLayout();
            this.glyphSearchTabPage.SuspendLayout();
            this.gSortGroupBox.SuspendLayout();
            this.gSearchParamsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayFullWeapons
            // 
            this.displayFullWeapons.AutoSize = true;
            this.displayFullWeapons.Location = new System.Drawing.Point(4, 17);
            this.displayFullWeapons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayFullWeapons.Name = "displayFullWeapons";
            this.displayFullWeapons.Size = new System.Drawing.Size(122, 17);
            this.displayFullWeapons.TabIndex = 0;
            this.displayFullWeapons.Text = "Display full weapons";
            this.displayFullWeapons.UseVisualStyleBackColor = true;
            this.displayFullWeapons.CheckedChanged += new System.EventHandler(this.OnDisplayWeaponsChanged);
            // 
            // displayFullGlyphs
            // 
            this.displayFullGlyphs.AutoSize = true;
            this.displayFullGlyphs.Location = new System.Drawing.Point(4, 39);
            this.displayFullGlyphs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayFullGlyphs.Name = "displayFullGlyphs";
            this.displayFullGlyphs.Size = new System.Drawing.Size(109, 17);
            this.displayFullGlyphs.TabIndex = 1;
            this.displayFullGlyphs.Text = "Display full glyphs";
            this.displayFullGlyphs.UseVisualStyleBackColor = true;
            this.displayFullGlyphs.CheckedChanged += new System.EventHandler(this.OnDisplayFullGlyphsChanged);
            // 
            // displayFullArmor
            // 
            this.displayFullArmor.AutoSize = true;
            this.displayFullArmor.Location = new System.Drawing.Point(4, 61);
            this.displayFullArmor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayFullArmor.Name = "displayFullArmor";
            this.displayFullArmor.Size = new System.Drawing.Size(105, 17);
            this.displayFullArmor.TabIndex = 2;
            this.displayFullArmor.Text = "Display full armor";
            this.displayFullArmor.UseVisualStyleBackColor = true;
            this.displayFullArmor.CheckedChanged += new System.EventHandler(this.OnDisplayFullArmorChanged);
            // 
            // avgPlrLvlLabel
            // 
            this.avgPlrLvlLabel.AutoSize = true;
            this.avgPlrLvlLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.avgPlrLvlLabel.Location = new System.Drawing.Point(5, 15);
            this.avgPlrLvlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgPlrLvlLabel.Name = "avgPlrLvlLabel";
            this.avgPlrLvlLabel.Size = new System.Drawing.Size(76, 13);
            this.avgPlrLvlLabel.TabIndex = 4;
            this.avgPlrLvlLabel.Text = "Average Level";
            this.avgPlrLvlLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // randomizeButton
            // 
            this.randomizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeButton.Location = new System.Drawing.Point(284, 13);
            this.randomizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(150, 32);
            this.randomizeButton.TabIndex = 1;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.OnRandomizeClicked);
            // 
            // enemyCountLabel
            // 
            this.enemyCountLabel.AutoSize = true;
            this.enemyCountLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enemyCountLabel.Location = new System.Drawing.Point(8, 51);
            this.enemyCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyCountLabel.Name = "enemyCountLabel";
            this.enemyCountLabel.Size = new System.Drawing.Size(70, 13);
            this.enemyCountLabel.TabIndex = 2;
            this.enemyCountLabel.Text = "Enemy Count";
            this.enemyCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(4, 143);
            this.output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(700, 497);
            this.output.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(284, 52);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 32);
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
            this.formatOptions.Location = new System.Drawing.Point(96, 4);
            this.formatOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formatOptions.Name = "formatOptions";
            this.formatOptions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formatOptions.Size = new System.Drawing.Size(127, 83);
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
            this.inputData.Location = new System.Drawing.Point(4, 4);
            this.inputData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputData.Name = "inputData";
            this.inputData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputData.Size = new System.Drawing.Size(87, 92);
            this.inputData.TabIndex = 0;
            this.inputData.TabStop = false;
            this.inputData.Text = "Input Data";
            // 
            // enemyCountBox
            // 
            this.enemyCountBox.Location = new System.Drawing.Point(6, 67);
            this.enemyCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enemyCountBox.Name = "enemyCountBox";
            this.enemyCountBox.Size = new System.Drawing.Size(75, 20);
            this.enemyCountBox.TabIndex = 1;
            this.enemyCountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // avgPlrLvlBox
            // 
            this.avgPlrLvlBox.Location = new System.Drawing.Point(6, 31);
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
            this.avgPlrLvlBox.Size = new System.Drawing.Size(75, 20);
            this.avgPlrLvlBox.TabIndex = 0;
            this.avgPlrLvlBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // randomModes
            // 
            this.randomModes.FormattingEnabled = true;
            this.randomModes.Items.AddRange(new object[] {
            "Normal mode",
            "More easy",
            "More medium",
            "More hard",
            "All easy",
            "All medium",
            "All hard"});
            this.randomModes.Location = new System.Drawing.Point(10, 17);
            this.randomModes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomModes.Name = "randomModes";
            this.randomModes.Size = new System.Drawing.Size(72, 95);
            this.randomModes.TabIndex = 12;
            // 
            // randomMode
            // 
            this.randomMode.Controls.Add(this.randomModes);
            this.randomMode.Location = new System.Drawing.Point(479, 5);
            this.randomMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomMode.Name = "randomMode";
            this.randomMode.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomMode.Size = new System.Drawing.Size(93, 120);
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
            this.gameClassNarowingGroupBox.Location = new System.Drawing.Point(577, 5);
            this.gameClassNarowingGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameClassNarowingGroupBox.Name = "gameClassNarowingGroupBox";
            this.gameClassNarowingGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameClassNarowingGroupBox.Size = new System.Drawing.Size(127, 120);
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
            this.gameClassNorowerBox.Location = new System.Drawing.Point(4, 15);
            this.gameClassNorowerBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameClassNorowerBox.Name = "gameClassNorowerBox";
            this.gameClassNorowerBox.Size = new System.Drawing.Size(116, 90);
            this.gameClassNorowerBox.TabIndex = 16;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.enemyGenerationTabPage);
            this.mainTabControl.Controls.Add(this.glyphSearchTabPage);
            this.mainTabControl.Controls.Add(this.weaponSearchTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(9, 10);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(716, 667);
            this.mainTabControl.TabIndex = 0;
            // 
            // enemyGenerationTabPage
            // 
            this.enemyGenerationTabPage.BackColor = System.Drawing.Color.Transparent;
            this.enemyGenerationTabPage.Controls.Add(this.inputData);
            this.enemyGenerationTabPage.Controls.Add(this.output);
            this.enemyGenerationTabPage.Controls.Add(this.randomMode);
            this.enemyGenerationTabPage.Controls.Add(this.gameClassNarowingGroupBox);
            this.enemyGenerationTabPage.Controls.Add(this.formatOptions);
            this.enemyGenerationTabPage.Controls.Add(this.saveButton);
            this.enemyGenerationTabPage.Controls.Add(this.randomizeButton);
            this.enemyGenerationTabPage.Location = new System.Drawing.Point(4, 22);
            this.enemyGenerationTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enemyGenerationTabPage.Name = "enemyGenerationTabPage";
            this.enemyGenerationTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enemyGenerationTabPage.Size = new System.Drawing.Size(708, 641);
            this.enemyGenerationTabPage.TabIndex = 0;
            this.enemyGenerationTabPage.Text = "Enemy Generation";
            // 
            // glyphSearchTabPage
            // 
            this.glyphSearchTabPage.BackColor = System.Drawing.Color.Transparent;
            this.glyphSearchTabPage.Controls.Add(this.gSearchResetButton);
            this.glyphSearchTabPage.Controls.Add(this.gSortGroupBox);
            this.glyphSearchTabPage.Controls.Add(this.gSearchParamsGroupBox);
            this.glyphSearchTabPage.Controls.Add(this.gSearchResultBox);
            this.glyphSearchTabPage.Controls.Add(this.searchResultsLabel);
            this.glyphSearchTabPage.Location = new System.Drawing.Point(4, 22);
            this.glyphSearchTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.glyphSearchTabPage.Name = "glyphSearchTabPage";
            this.glyphSearchTabPage.Size = new System.Drawing.Size(708, 641);
            this.glyphSearchTabPage.TabIndex = 2;
            this.glyphSearchTabPage.Text = "Glyph Search";
            // 
            // gSortGroupBox
            // 
            this.gSortGroupBox.Controls.Add(this.gSearchResultsSortBox);
            this.gSortGroupBox.Location = new System.Drawing.Point(16, 88);
            this.gSortGroupBox.Name = "gSortGroupBox";
            this.gSortGroupBox.Size = new System.Drawing.Size(188, 52);
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
            this.gSearchResultsSortBox.Location = new System.Drawing.Point(6, 19);
            this.gSearchResultsSortBox.Name = "gSearchResultsSortBox";
            this.gSearchResultsSortBox.Size = new System.Drawing.Size(173, 21);
            this.gSearchResultsSortBox.TabIndex = 0;
            this.gSearchResultsSortBox.SelectedIndexChanged += new System.EventHandler(this.OnGlyphSearchSortTypeChanged);
            // 
            // gSearchParamsGroupBox
            // 
            this.gSearchParamsGroupBox.Controls.Add(this.glyphSearchInputBox1);
            this.gSearchParamsGroupBox.Controls.Add(this.glyphSearchInputBox2);
            this.gSearchParamsGroupBox.Controls.Add(this.glyphSearchTypeBox1);
            this.gSearchParamsGroupBox.Controls.Add(this.glyphSearchTypeBox2);
            this.gSearchParamsGroupBox.Location = new System.Drawing.Point(16, 3);
            this.gSearchParamsGroupBox.Name = "gSearchParamsGroupBox";
            this.gSearchParamsGroupBox.Size = new System.Drawing.Size(676, 79);
            this.gSearchParamsGroupBox.TabIndex = 6;
            this.gSearchParamsGroupBox.TabStop = false;
            this.gSearchParamsGroupBox.Text = "Search";
            // 
            // glyphSearchInputBox1
            // 
            this.glyphSearchInputBox1.Location = new System.Drawing.Point(6, 19);
            this.glyphSearchInputBox1.Name = "glyphSearchInputBox1";
            this.glyphSearchInputBox1.Size = new System.Drawing.Size(468, 20);
            this.glyphSearchInputBox1.TabIndex = 1;
            this.glyphSearchInputBox1.TextChanged += new System.EventHandler(this.OnGlyphSearchInputBox1TextChanged);
            // 
            // glyphSearchInputBox2
            // 
            this.glyphSearchInputBox2.Location = new System.Drawing.Point(6, 45);
            this.glyphSearchInputBox2.Name = "glyphSearchInputBox2";
            this.glyphSearchInputBox2.Size = new System.Drawing.Size(468, 20);
            this.glyphSearchInputBox2.TabIndex = 2;
            this.glyphSearchInputBox2.TextChanged += new System.EventHandler(this.OnGlyphSearchInputBox2TextChanged);
            // 
            // glyphSearchTypeBox1
            // 
            this.glyphSearchTypeBox1.FormattingEnabled = true;
            this.glyphSearchTypeBox1.Location = new System.Drawing.Point(497, 18);
            this.glyphSearchTypeBox1.Name = "glyphSearchTypeBox1";
            this.glyphSearchTypeBox1.Size = new System.Drawing.Size(173, 21);
            this.glyphSearchTypeBox1.TabIndex = 0;
            this.glyphSearchTypeBox1.SelectedIndexChanged += new System.EventHandler(this.OnGlyphSearchTypeChanged);
            // 
            // glyphSearchTypeBox2
            // 
            this.glyphSearchTypeBox2.FormattingEnabled = true;
            this.glyphSearchTypeBox2.Location = new System.Drawing.Point(497, 44);
            this.glyphSearchTypeBox2.Name = "glyphSearchTypeBox2";
            this.glyphSearchTypeBox2.Size = new System.Drawing.Size(173, 21);
            this.glyphSearchTypeBox2.TabIndex = 0;
            this.glyphSearchTypeBox2.SelectedIndexChanged += new System.EventHandler(this.OnGlyphSearchTypeChanged);
            // 
            // gSearchResultBox
            // 
            this.gSearchResultBox.BackColor = System.Drawing.SystemColors.Window;
            this.gSearchResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gSearchResultBox.Location = new System.Drawing.Point(16, 163);
            this.gSearchResultBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gSearchResultBox.Name = "gSearchResultBox";
            this.gSearchResultBox.ReadOnly = true;
            this.gSearchResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.gSearchResultBox.Size = new System.Drawing.Size(676, 465);
            this.gSearchResultBox.TabIndex = 5;
            this.gSearchResultBox.Text = "";
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.Location = new System.Drawing.Point(13, 143);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(52, 18);
            this.searchResultsLabel.TabIndex = 4;
            this.searchResultsLabel.Text = "results";
            // 
            // weaponSearchTabPage
            // 
            this.weaponSearchTabPage.BackColor = System.Drawing.Color.Transparent;
            this.weaponSearchTabPage.Location = new System.Drawing.Point(4, 22);
            this.weaponSearchTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weaponSearchTabPage.Name = "weaponSearchTabPage";
            this.weaponSearchTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weaponSearchTabPage.Size = new System.Drawing.Size(708, 641);
            this.weaponSearchTabPage.TabIndex = 1;
            this.weaponSearchTabPage.Text = "Weapon Search";
            // 
            // gSearchResetButton
            // 
            this.gSearchResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gSearchResetButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gSearchResetButton.Location = new System.Drawing.Point(596, 105);
            this.gSearchResetButton.Name = "gSearchResetButton";
            this.gSearchResetButton.Size = new System.Drawing.Size(96, 35);
            this.gSearchResetButton.TabIndex = 8;
            this.gSearchResetButton.Text = "Reset";
            this.gSearchResetButton.UseVisualStyleBackColor = true;
            this.gSearchResetButton.Click += new System.EventHandler(this.ResetGSearch);
            // 
            // QegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 687);
            this.Controls.Add(this.mainTabControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "QegForm";
            this.Text = "QEG 1.0";
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
            this.enemyGenerationTabPage.ResumeLayout(false);
            this.enemyGenerationTabPage.PerformLayout();
            this.glyphSearchTabPage.ResumeLayout(false);
            this.glyphSearchTabPage.PerformLayout();
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
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox formatOptions;
        private System.Windows.Forms.GroupBox inputData;
        private System.Windows.Forms.ListBox randomModes;
        private System.Windows.Forms.GroupBox randomMode;
        private System.Windows.Forms.SaveFileDialog saveFileToTxtDialog;
        private System.Windows.Forms.GroupBox gameClassNarowingGroupBox;
        private System.Windows.Forms.CheckedListBox gameClassNorowerBox;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage enemyGenerationTabPage;
        private System.Windows.Forms.TabPage weaponSearchTabPage;
        private System.Windows.Forms.TabPage glyphSearchTabPage;
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
    }
}

