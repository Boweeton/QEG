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
            this.SuspendLayout();
            // 
            // displayFullWeapons
            // 
            this.displayFullWeapons.AutoSize = true;
            this.displayFullWeapons.Location = new System.Drawing.Point(127, 12);
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
            this.displayFullGlyphs.Location = new System.Drawing.Point(127, 48);
            this.displayFullGlyphs.Name = "displayFullGlyphs";
            this.displayFullGlyphs.Size = new System.Drawing.Size(143, 21);
            this.displayFullGlyphs.TabIndex = 1;
            this.displayFullGlyphs.Text = "Display full glyphs";
            this.displayFullGlyphs.UseVisualStyleBackColor = true;
            // 
            // displayFullArmor
            // 
            this.displayFullArmor.AutoSize = true;
            this.displayFullArmor.Location = new System.Drawing.Point(127, 83);
            this.displayFullArmor.Name = "displayFullArmor";
            this.displayFullArmor.Size = new System.Drawing.Size(139, 21);
            this.displayFullArmor.TabIndex = 2;
            this.displayFullArmor.Text = "Display full armor";
            this.displayFullArmor.UseVisualStyleBackColor = true;
            // 
            // avgPlrLvl
            // 
            this.avgPlrLvl.Location = new System.Drawing.Point(12, 29);
            this.avgPlrLvl.Name = "avgPlrLvl";
            this.avgPlrLvl.Size = new System.Drawing.Size(99, 22);
            this.avgPlrLvl.TabIndex = 3;
            this.avgPlrLvl.TextChanged += new System.EventHandler(this.AvgPlrLvl_TextChanged);
            // 
            // avgPlrLvlLabel
            // 
            this.avgPlrLvlLabel.AutoSize = true;
            this.avgPlrLvlLabel.Location = new System.Drawing.Point(12, 9);
            this.avgPlrLvlLabel.Name = "avgPlrLvlLabel";
            this.avgPlrLvlLabel.Size = new System.Drawing.Size(99, 17);
            this.avgPlrLvlLabel.TabIndex = 4;
            this.avgPlrLvlLabel.Text = "Average Level";
            // 
            // randomize
            // 
            this.randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomize.Location = new System.Drawing.Point(354, 41);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(233, 49);
            this.randomize.TabIndex = 5;
            this.randomize.Text = "Randomize";
            this.randomize.UseVisualStyleBackColor = true;
            // 
            // enemyCountLabel
            // 
            this.enemyCountLabel.AutoSize = true;
            this.enemyCountLabel.Location = new System.Drawing.Point(12, 63);
            this.enemyCountLabel.Name = "enemyCountLabel";
            this.enemyCountLabel.Size = new System.Drawing.Size(92, 17);
            this.enemyCountLabel.TabIndex = 7;
            this.enemyCountLabel.Text = "Enemy Count";
            this.enemyCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // enemyCount
            // 
            this.enemyCount.Location = new System.Drawing.Point(12, 83);
            this.enemyCount.Name = "enemyCount";
            this.enemyCount.Size = new System.Drawing.Size(99, 22);
            this.enemyCount.TabIndex = 6;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(12, 127);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(931, 695);
            this.output.TabIndex = 8;
            this.output.WordWrap = false;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(641, 41);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(233, 49);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print to .txt";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // QEG_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(956, 835);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.enemyCountLabel);
            this.Controls.Add(this.enemyCount);
            this.Controls.Add(this.randomize);
            this.Controls.Add(this.avgPlrLvlLabel);
            this.Controls.Add(this.avgPlrLvl);
            this.Controls.Add(this.displayFullArmor);
            this.Controls.Add(this.displayFullGlyphs);
            this.Controls.Add(this.displayFullWeapons);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QEG_Form";
            this.Text = "QEG 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

