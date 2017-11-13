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
            this.gSearchResultBox = new System.Windows.Forms.RichTextBox();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.glyphSearchTypeBox2 = new System.Windows.Forms.ComboBox();
            this.glyphSearchTypeBox1 = new System.Windows.Forms.ComboBox();
            this.glyphSearchInputBox2 = new System.Windows.Forms.TextBox();
            this.glyphSearchInputBox1 = new System.Windows.Forms.TextBox();
            this.glyphSearchLabel = new System.Windows.Forms.Label();
            this.weaponSearchTabPage = new System.Windows.Forms.TabPage();
            this.formatOptions.SuspendLayout();
            this.inputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgPlrLvlBox)).BeginInit();
            this.randomMode.SuspendLayout();
            this.gameClassNarowingGroupBox.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.enemyGenerationTabPage.SuspendLayout();
            this.glyphSearchTabPage.SuspendLayout();
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
            this.randomizeButton.Location = new System.Drawing.Point(379, 16);
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
            // output
            // 
            this.output.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(5, 176);
            this.output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(932, 611);
            this.output.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(379, 64);
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
            this.enemyCountBox.Margin = new System.Windows.Forms.Padding(4);
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
            // 
            // avgPlrLvlBox
            // 
            this.avgPlrLvlBox.Location = new System.Drawing.Point(8, 38);
            this.avgPlrLvlBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.gameClassNarowingGroupBox.Size = new System.Drawing.Size(169, 118);
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
            this.gameClassNorowerBox.Size = new System.Drawing.Size(155, 85);
            this.gameClassNorowerBox.TabIndex = 16;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.enemyGenerationTabPage);
            this.mainTabControl.Controls.Add(this.glyphSearchTabPage);
            this.mainTabControl.Controls.Add(this.weaponSearchTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(955, 821);
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
            this.enemyGenerationTabPage.Location = new System.Drawing.Point(4, 25);
            this.enemyGenerationTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyGenerationTabPage.Name = "enemyGenerationTabPage";
            this.enemyGenerationTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyGenerationTabPage.Size = new System.Drawing.Size(947, 792);
            this.enemyGenerationTabPage.TabIndex = 0;
            this.enemyGenerationTabPage.Text = "Enemy Generation";
            // 
            // glyphSearchTabPage
            // 
            this.glyphSearchTabPage.BackColor = System.Drawing.Color.Transparent;
            this.glyphSearchTabPage.Controls.Add(this.gSearchResultBox);
            this.glyphSearchTabPage.Controls.Add(this.searchResultsLabel);
            this.glyphSearchTabPage.Controls.Add(this.glyphSearchTypeBox2);
            this.glyphSearchTabPage.Controls.Add(this.glyphSearchTypeBox1);
            this.glyphSearchTabPage.Controls.Add(this.glyphSearchInputBox2);
            this.glyphSearchTabPage.Controls.Add(this.glyphSearchInputBox1);
            this.glyphSearchTabPage.Controls.Add(this.glyphSearchLabel);
            this.glyphSearchTabPage.Location = new System.Drawing.Point(4, 25);
            this.glyphSearchTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glyphSearchTabPage.Name = "glyphSearchTabPage";
            this.glyphSearchTabPage.Size = new System.Drawing.Size(947, 792);
            this.glyphSearchTabPage.TabIndex = 2;
            this.glyphSearchTabPage.Text = "Glyph Search";
            // 
            // gSearchResultBox
            // 
            this.gSearchResultBox.BackColor = System.Drawing.SystemColors.Window;
            this.gSearchResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gSearchResultBox.Location = new System.Drawing.Point(22, 137);
            this.gSearchResultBox.Name = "gSearchResultBox";
            this.gSearchResultBox.ReadOnly = true;
            this.gSearchResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.gSearchResultBox.Size = new System.Drawing.Size(900, 635);
            this.gSearchResultBox.TabIndex = 5;
            this.gSearchResultBox.Text = "";
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Location = new System.Drawing.Point(23, 116);
            this.searchResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(50, 17);
            this.searchResultsLabel.TabIndex = 4;
            this.searchResultsLabel.Text = "results";
            // 
            // glyphSearchTypeBox2
            // 
            this.glyphSearchTypeBox2.FormattingEnabled = true;
            this.glyphSearchTypeBox2.Location = new System.Drawing.Point(693, 64);
            this.glyphSearchTypeBox2.Margin = new System.Windows.Forms.Padding(4);
            this.glyphSearchTypeBox2.Name = "glyphSearchTypeBox2";
            this.glyphSearchTypeBox2.Size = new System.Drawing.Size(229, 24);
            this.glyphSearchTypeBox2.TabIndex = 0;
            this.glyphSearchTypeBox2.SelectedIndexChanged += new System.EventHandler(this.OnGlyphSearchTypeChanged);
            // 
            // glyphSearchTypeBox1
            // 
            this.glyphSearchTypeBox1.FormattingEnabled = true;
            this.glyphSearchTypeBox1.Location = new System.Drawing.Point(693, 32);
            this.glyphSearchTypeBox1.Margin = new System.Windows.Forms.Padding(4);
            this.glyphSearchTypeBox1.Name = "glyphSearchTypeBox1";
            this.glyphSearchTypeBox1.Size = new System.Drawing.Size(229, 24);
            this.glyphSearchTypeBox1.TabIndex = 0;
            this.glyphSearchTypeBox1.SelectedIndexChanged += new System.EventHandler(this.OnGlyphSearchTypeChanged);
            // 
            // glyphSearchInputBox2
            // 
            this.glyphSearchInputBox2.Location = new System.Drawing.Point(23, 65);
            this.glyphSearchInputBox2.Margin = new System.Windows.Forms.Padding(4);
            this.glyphSearchInputBox2.Name = "glyphSearchInputBox2";
            this.glyphSearchInputBox2.Size = new System.Drawing.Size(661, 22);
            this.glyphSearchInputBox2.TabIndex = 2;
            this.glyphSearchInputBox2.TextChanged += new System.EventHandler(this.OnGlyphSearchInputBox2TextChanged);
            // 
            // glyphSearchInputBox1
            // 
            this.glyphSearchInputBox1.Location = new System.Drawing.Point(23, 33);
            this.glyphSearchInputBox1.Margin = new System.Windows.Forms.Padding(4);
            this.glyphSearchInputBox1.Name = "glyphSearchInputBox1";
            this.glyphSearchInputBox1.Size = new System.Drawing.Size(661, 22);
            this.glyphSearchInputBox1.TabIndex = 1;
            this.glyphSearchInputBox1.TextChanged += new System.EventHandler(this.OnGlyphSearchInputBox1TextChanged);
            // 
            // glyphSearchLabel
            // 
            this.glyphSearchLabel.AutoSize = true;
            this.glyphSearchLabel.Location = new System.Drawing.Point(19, 12);
            this.glyphSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.glyphSearchLabel.Name = "glyphSearchLabel";
            this.glyphSearchLabel.Size = new System.Drawing.Size(53, 17);
            this.glyphSearchLabel.TabIndex = 0;
            this.glyphSearchLabel.Text = "Search";
            // 
            // weaponSearchTabPage
            // 
            this.weaponSearchTabPage.BackColor = System.Drawing.Color.Transparent;
            this.weaponSearchTabPage.Location = new System.Drawing.Point(4, 25);
            this.weaponSearchTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weaponSearchTabPage.Name = "weaponSearchTabPage";
            this.weaponSearchTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weaponSearchTabPage.Size = new System.Drawing.Size(947, 792);
            this.weaponSearchTabPage.TabIndex = 1;
            this.weaponSearchTabPage.Text = "Weapon Search";
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
        private System.Windows.Forms.Label glyphSearchLabel;
        private System.Windows.Forms.ComboBox glyphSearchTypeBox1;
        private System.Windows.Forms.TextBox glyphSearchInputBox1;
        private System.Windows.Forms.ComboBox glyphSearchTypeBox2;
        private System.Windows.Forms.TextBox glyphSearchInputBox2;
        private System.Windows.Forms.Label searchResultsLabel;
        private System.Windows.Forms.NumericUpDown enemyCountBox;
        private System.Windows.Forms.NumericUpDown avgPlrLvlBox;
        private System.Windows.Forms.RichTextBox gSearchResultBox;
    }
}

