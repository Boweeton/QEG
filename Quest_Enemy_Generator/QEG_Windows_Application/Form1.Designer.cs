namespace QEG_Windows_Application
{
    partial class QEGForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QEGForm));
            this.displayFullWeapons = new System.Windows.Forms.CheckBox();
            this.displayFullGlyphs = new System.Windows.Forms.CheckBox();
            this.displayFullArmor = new System.Windows.Forms.CheckBox();
            this.avgPlrLvlBox = new System.Windows.Forms.TextBox();
            this.avgPlrLvlLabel = new System.Windows.Forms.Label();
            this.randomize = new System.Windows.Forms.Button();
            this.enemyCountLabel = new System.Windows.Forms.Label();
            this.enemyCountBox = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.formatOptions = new System.Windows.Forms.GroupBox();
            this.inputData = new System.Windows.Forms.GroupBox();
            this.randomModes = new System.Windows.Forms.ListBox();
            this.randomMode = new System.Windows.Forms.GroupBox();
            this.saveFileToTxtDialog = new System.Windows.Forms.SaveFileDialog();
            this.formatOptions.SuspendLayout();
            this.inputData.SuspendLayout();
            this.randomMode.SuspendLayout();
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
            this.displayFullWeapons.CheckedChanged += new System.EventHandler(this.DisplayFullWeapons_CheckedChanged);
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
            this.displayFullGlyphs.CheckedChanged += new System.EventHandler(this.displayFullGlyphs_CheckedChanged);
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
            this.displayFullArmor.CheckedChanged += new System.EventHandler(this.displayFullArmor_CheckedChanged);
            // 
            // avgPlrLvlBox
            // 
            this.avgPlrLvlBox.Location = new System.Drawing.Point(4, 31);
            this.avgPlrLvlBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgPlrLvlBox.Name = "avgPlrLvlBox";
            this.avgPlrLvlBox.Size = new System.Drawing.Size(75, 20);
            this.avgPlrLvlBox.TabIndex = 0;
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
            // randomize
            // 
            this.randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomize.Location = new System.Drawing.Point(248, 12);
            this.randomize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(175, 40);
            this.randomize.TabIndex = 1;
            this.randomize.Text = "Randomize";
            this.randomize.UseVisualStyleBackColor = true;
            this.randomize.Click += new System.EventHandler(this.randomize_Click);
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
            // enemyCountBox
            // 
            this.enemyCountBox.Location = new System.Drawing.Point(4, 67);
            this.enemyCountBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enemyCountBox.Name = "enemyCountBox";
            this.enemyCountBox.Size = new System.Drawing.Size(75, 20);
            this.enemyCountBox.TabIndex = 1;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(11, 134);
            this.output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(700, 540);
            this.output.TabIndex = 8;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(248, 70);
            this.printButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(175, 40);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Save";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // formatOptions
            // 
            this.formatOptions.Controls.Add(this.displayFullWeapons);
            this.formatOptions.Controls.Add(this.displayFullGlyphs);
            this.formatOptions.Controls.Add(this.displayFullArmor);
            this.formatOptions.Location = new System.Drawing.Point(100, 10);
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
            this.inputData.Controls.Add(this.avgPlrLvlLabel);
            this.inputData.Controls.Add(this.avgPlrLvlBox);
            this.inputData.Controls.Add(this.enemyCountBox);
            this.inputData.Controls.Add(this.enemyCountLabel);
            this.inputData.Location = new System.Drawing.Point(9, 10);
            this.inputData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputData.Name = "inputData";
            this.inputData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputData.Size = new System.Drawing.Size(87, 92);
            this.inputData.TabIndex = 0;
            this.inputData.TabStop = false;
            this.inputData.Text = "Input Data";
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
            this.randomMode.Location = new System.Drawing.Point(442, 10);
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
            // QEGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(724, 685);
            this.Controls.Add(this.randomMode);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.formatOptions);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.randomize);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "QEGForm";
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
        private System.Windows.Forms.TextBox avgPlrLvlBox;
        private System.Windows.Forms.Label avgPlrLvlLabel;
        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.Label enemyCountLabel;
        private System.Windows.Forms.TextBox enemyCountBox;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.GroupBox formatOptions;
        private System.Windows.Forms.GroupBox inputData;
        private System.Windows.Forms.ListBox randomModes;
        private System.Windows.Forms.GroupBox randomMode;
        private System.Windows.Forms.SaveFileDialog saveFileToTxtDialog;
    }
}

