namespace QEG_Windows_Application
{
    partial class QEG_Form
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
            this.displayFullWeapons = new System.Windows.Forms.CheckBox();
            this.displayFullGlyphs = new System.Windows.Forms.CheckBox();
            this.displayFullArmor = new System.Windows.Forms.CheckBox();
            this.avgPlrLvl = new System.Windows.Forms.TextBox();
            this.avgPlrLvlLabel = new System.Windows.Forms.Label();
            this.randomize = new System.Windows.Forms.Button();
            this.enemyCountLabel = new System.Windows.Forms.Label();
            this.enemyCount = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.formatOptions = new System.Windows.Forms.GroupBox();
            this.inputData = new System.Windows.Forms.GroupBox();
            this.randomModes = new System.Windows.Forms.ListBox();
            this.randomMode = new System.Windows.Forms.GroupBox();
            this.formatOptions.SuspendLayout();
            this.inputData.SuspendLayout();
            this.randomMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayFullWeapons
            // 
            this.displayFullWeapons.AutoSize = true;
            this.displayFullWeapons.Location = new System.Drawing.Point(6, 21);
            this.displayFullWeapons.Name = "displayFullWeapons";
            this.displayFullWeapons.Size = new System.Drawing.Size(158, 21);
            this.displayFullWeapons.TabIndex = 0;
            this.displayFullWeapons.Text = "Display full weapons";
            this.displayFullWeapons.UseVisualStyleBackColor = true;
            this.displayFullWeapons.CheckedChanged += new System.EventHandler(this.DisplayFullWeapons_CheckedChanged);
            // 
            // displayFullGlyphs
            // 
            this.displayFullGlyphs.AutoSize = true;
            this.displayFullGlyphs.Location = new System.Drawing.Point(6, 48);
            this.displayFullGlyphs.Name = "displayFullGlyphs";
            this.displayFullGlyphs.Size = new System.Drawing.Size(143, 21);
            this.displayFullGlyphs.TabIndex = 1;
            this.displayFullGlyphs.Text = "Display full glyphs";
            this.displayFullGlyphs.UseVisualStyleBackColor = true;
            this.displayFullGlyphs.CheckedChanged += new System.EventHandler(this.displayFullGlyphs_CheckedChanged);
            // 
            // displayFullArmor
            // 
            this.displayFullArmor.AutoSize = true;
            this.displayFullArmor.Location = new System.Drawing.Point(6, 75);
            this.displayFullArmor.Name = "displayFullArmor";
            this.displayFullArmor.Size = new System.Drawing.Size(139, 21);
            this.displayFullArmor.TabIndex = 2;
            this.displayFullArmor.Text = "Display full armor";
            this.displayFullArmor.UseVisualStyleBackColor = true;
            this.displayFullArmor.CheckedChanged += new System.EventHandler(this.displayFullArmor_CheckedChanged);
            // 
            // avgPlrLvl
            // 
            this.avgPlrLvl.Location = new System.Drawing.Point(6, 38);
            this.avgPlrLvl.Name = "avgPlrLvl";
            this.avgPlrLvl.Size = new System.Drawing.Size(99, 22);
            this.avgPlrLvl.TabIndex = 3;
            this.avgPlrLvl.TextChanged += new System.EventHandler(this.avgPlrLvl_TextChanged);
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
            // randomize
            // 
            this.randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomize.Location = new System.Drawing.Point(331, 15);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(233, 49);
            this.randomize.TabIndex = 5;
            this.randomize.Text = "Randomize";
            this.randomize.UseVisualStyleBackColor = true;
            this.randomize.Click += new System.EventHandler(this.randomize_Click);
            // 
            // enemyCountLabel
            // 
            this.enemyCountLabel.AutoSize = true;
            this.enemyCountLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enemyCountLabel.Location = new System.Drawing.Point(10, 63);
            this.enemyCountLabel.Name = "enemyCountLabel";
            this.enemyCountLabel.Size = new System.Drawing.Size(92, 17);
            this.enemyCountLabel.TabIndex = 7;
            this.enemyCountLabel.Text = "Enemy Count";
            this.enemyCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enemyCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // enemyCount
            // 
            this.enemyCount.Location = new System.Drawing.Point(6, 83);
            this.enemyCount.Name = "enemyCount";
            this.enemyCount.Size = new System.Drawing.Size(99, 22);
            this.enemyCount.TabIndex = 6;
            this.enemyCount.TextChanged += new System.EventHandler(this.enemyCount_TextChanged);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(12, 166);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(931, 656);
            this.output.TabIndex = 8;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(331, 86);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(233, 49);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print to .txt";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // formatOptions
            // 
            this.formatOptions.Controls.Add(this.displayFullWeapons);
            this.formatOptions.Controls.Add(this.displayFullGlyphs);
            this.formatOptions.Controls.Add(this.displayFullArmor);
            this.formatOptions.Location = new System.Drawing.Point(134, 12);
            this.formatOptions.Name = "formatOptions";
            this.formatOptions.Size = new System.Drawing.Size(169, 102);
            this.formatOptions.TabIndex = 10;
            this.formatOptions.TabStop = false;
            this.formatOptions.Text = "Formatting Options";
            // 
            // inputData
            // 
            this.inputData.Controls.Add(this.avgPlrLvlLabel);
            this.inputData.Controls.Add(this.avgPlrLvl);
            this.inputData.Controls.Add(this.enemyCount);
            this.inputData.Controls.Add(this.enemyCountLabel);
            this.inputData.Location = new System.Drawing.Point(12, 12);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(116, 113);
            this.inputData.TabIndex = 11;
            this.inputData.TabStop = false;
            this.inputData.Text = "Input Data";
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
            this.randomModes.Name = "randomModes";
            this.randomModes.Size = new System.Drawing.Size(95, 116);
            this.randomModes.TabIndex = 12;
            this.randomModes.SelectedIndexChanged += new System.EventHandler(this.randomModes_SelectedIndexChanged);
            // 
            // randomMode
            // 
            this.randomMode.Controls.Add(this.randomModes);
            this.randomMode.Location = new System.Drawing.Point(589, 12);
            this.randomMode.Name = "randomMode";
            this.randomMode.Size = new System.Drawing.Size(124, 148);
            this.randomMode.TabIndex = 13;
            this.randomMode.TabStop = false;
            this.randomMode.Text = "Random Mode";
            // 
            // QEG_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(956, 835);
            this.Controls.Add(this.randomMode);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.formatOptions);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.randomize);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QEG_Form";
            this.Text = "QEG 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formatOptions.ResumeLayout(false);
            this.formatOptions.PerformLayout();
            this.inputData.ResumeLayout(false);
            this.inputData.PerformLayout();
            this.randomMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox displayFullWeapons;
        private System.Windows.Forms.CheckBox displayFullGlyphs;
        private System.Windows.Forms.CheckBox displayFullArmor;
        private System.Windows.Forms.TextBox avgPlrLvl;
        private System.Windows.Forms.Label avgPlrLvlLabel;
        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.Label enemyCountLabel;
        private System.Windows.Forms.TextBox enemyCount;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.GroupBox formatOptions;
        private System.Windows.Forms.GroupBox inputData;
        private System.Windows.Forms.ListBox randomModes;
        private System.Windows.Forms.GroupBox randomMode;
    }
}

