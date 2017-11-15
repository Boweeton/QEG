namespace XMLManager
{
    partial class XmlManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XmlManagerForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.manageGlyphs = new System.Windows.Forms.TabPage();
            this.searchForGlyphButton = new System.Windows.Forms.Button();
            this.discardChangesButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.manageWeapons = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.manageGlyphs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.manageGlyphs);
            this.tabControl1.Controls.Add(this.manageWeapons);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 542);
            this.tabControl1.TabIndex = 0;
            // 
            // manageGlyphs
            // 
            this.manageGlyphs.BackColor = System.Drawing.SystemColors.Control;
            this.manageGlyphs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageGlyphs.Controls.Add(this.searchForGlyphButton);
            this.manageGlyphs.Controls.Add(this.discardChangesButton);
            this.manageGlyphs.Controls.Add(this.saveChangesButton);
            this.manageGlyphs.Location = new System.Drawing.Point(4, 25);
            this.manageGlyphs.Name = "manageGlyphs";
            this.manageGlyphs.Padding = new System.Windows.Forms.Padding(3);
            this.manageGlyphs.Size = new System.Drawing.Size(550, 513);
            this.manageGlyphs.TabIndex = 0;
            this.manageGlyphs.Text = "Manage Glyphs";
            // 
            // searchForGlyphButton
            // 
            this.searchForGlyphButton.Location = new System.Drawing.Point(6, 6);
            this.searchForGlyphButton.Name = "searchForGlyphButton";
            this.searchForGlyphButton.Size = new System.Drawing.Size(130, 30);
            this.searchForGlyphButton.TabIndex = 1;
            this.searchForGlyphButton.Text = "Search For Glyph";
            this.searchForGlyphButton.UseVisualStyleBackColor = true;
            // 
            // discardChangesButton
            // 
            this.discardChangesButton.Location = new System.Drawing.Point(402, 42);
            this.discardChangesButton.Name = "discardChangesButton";
            this.discardChangesButton.Size = new System.Drawing.Size(140, 30);
            this.discardChangesButton.TabIndex = 0;
            this.discardChangesButton.Text = "Discard Changes";
            this.discardChangesButton.UseVisualStyleBackColor = true;
            this.discardChangesButton.Click += new System.EventHandler(this.OnDiscardChangesButtonClick);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(402, 6);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(140, 30);
            this.saveChangesButton.TabIndex = 0;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.OnSaveChangesButtonClick);
            // 
            // manageWeapons
            // 
            this.manageWeapons.Location = new System.Drawing.Point(4, 25);
            this.manageWeapons.Name = "manageWeapons";
            this.manageWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.manageWeapons.Size = new System.Drawing.Size(550, 513);
            this.manageWeapons.TabIndex = 1;
            this.manageWeapons.Text = "Manage Weapons";
            this.manageWeapons.UseVisualStyleBackColor = true;
            // 
            // XMLManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 567);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XmlManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.XMLManagerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.manageGlyphs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage manageGlyphs;
        private System.Windows.Forms.TabPage manageWeapons;
        private System.Windows.Forms.Button discardChangesButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button searchForGlyphButton;
    }
}

