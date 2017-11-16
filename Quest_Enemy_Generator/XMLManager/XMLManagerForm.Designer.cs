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
            this.narrowGlyphsByNameBox = new System.Windows.Forms.GroupBox();
            this.resultsNarrowBox = new System.Windows.Forms.TextBox();
            this.editGlyphsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteSelectedGlyphButton = new System.Windows.Forms.Button();
            this.editSelectedGlyphButton = new System.Windows.Forms.Button();
            this.addNewGlyphButton = new System.Windows.Forms.Button();
            this.fileManagmentGroupBox = new System.Windows.Forms.GroupBox();
            this.loadGlyphsFileButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.discardChangesButton = new System.Windows.Forms.Button();
            this.manageWeapons = new System.Windows.Forms.TabPage();
            this.loadGmtFilesInterface = new System.Windows.Forms.OpenFileDialog();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.manageGlyphs.SuspendLayout();
            this.narrowGlyphsByNameBox.SuspendLayout();
            this.editGlyphsGroupBox.SuspendLayout();
            this.fileManagmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.manageGlyphs);
            this.tabControl1.Controls.Add(this.manageWeapons);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // manageGlyphs
            // 
            this.manageGlyphs.BackColor = System.Drawing.SystemColors.Control;
            this.manageGlyphs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageGlyphs.Controls.Add(this.displayPanel);
            this.manageGlyphs.Controls.Add(this.narrowGlyphsByNameBox);
            this.manageGlyphs.Controls.Add(this.editGlyphsGroupBox);
            this.manageGlyphs.Controls.Add(this.fileManagmentGroupBox);
            this.manageGlyphs.Location = new System.Drawing.Point(4, 22);
            this.manageGlyphs.Margin = new System.Windows.Forms.Padding(2);
            this.manageGlyphs.Name = "manageGlyphs";
            this.manageGlyphs.Padding = new System.Windows.Forms.Padding(2);
            this.manageGlyphs.Size = new System.Drawing.Size(470, 600);
            this.manageGlyphs.TabIndex = 0;
            this.manageGlyphs.Text = "Manage Glyphs";
            // 
            // narrowGlyphsByNameBox
            // 
            this.narrowGlyphsByNameBox.Controls.Add(this.resultsNarrowBox);
            this.narrowGlyphsByNameBox.Location = new System.Drawing.Point(5, 115);
            this.narrowGlyphsByNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.narrowGlyphsByNameBox.Name = "narrowGlyphsByNameBox";
            this.narrowGlyphsByNameBox.Padding = new System.Windows.Forms.Padding(2);
            this.narrowGlyphsByNameBox.Size = new System.Drawing.Size(459, 42);
            this.narrowGlyphsByNameBox.TabIndex = 4;
            this.narrowGlyphsByNameBox.TabStop = false;
            this.narrowGlyphsByNameBox.Text = "Narrow By Name";
            // 
            // resultsNarrowBox
            // 
            this.resultsNarrowBox.Location = new System.Drawing.Point(4, 18);
            this.resultsNarrowBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultsNarrowBox.Name = "resultsNarrowBox";
            this.resultsNarrowBox.Size = new System.Drawing.Size(451, 20);
            this.resultsNarrowBox.TabIndex = 0;
            // 
            // editGlyphsGroupBox
            // 
            this.editGlyphsGroupBox.Controls.Add(this.deleteSelectedGlyphButton);
            this.editGlyphsGroupBox.Controls.Add(this.editSelectedGlyphButton);
            this.editGlyphsGroupBox.Controls.Add(this.addNewGlyphButton);
            this.editGlyphsGroupBox.Location = new System.Drawing.Point(4, 60);
            this.editGlyphsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.editGlyphsGroupBox.Name = "editGlyphsGroupBox";
            this.editGlyphsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.editGlyphsGroupBox.Size = new System.Drawing.Size(460, 50);
            this.editGlyphsGroupBox.TabIndex = 3;
            this.editGlyphsGroupBox.TabStop = false;
            this.editGlyphsGroupBox.Text = "Edit Glyphs";
            // 
            // deleteSelectedGlyphButton
            // 
            this.deleteSelectedGlyphButton.Location = new System.Drawing.Point(216, 17);
            this.deleteSelectedGlyphButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteSelectedGlyphButton.Name = "deleteSelectedGlyphButton";
            this.deleteSelectedGlyphButton.Size = new System.Drawing.Size(105, 24);
            this.deleteSelectedGlyphButton.TabIndex = 1;
            this.deleteSelectedGlyphButton.Text = "Delete Selected";
            this.deleteSelectedGlyphButton.UseVisualStyleBackColor = true;
            this.deleteSelectedGlyphButton.Click += new System.EventHandler(this.deleteSelectedGlyphButton_Click);
            // 
            // editSelectedGlyphButton
            // 
            this.editSelectedGlyphButton.Location = new System.Drawing.Point(106, 17);
            this.editSelectedGlyphButton.Margin = new System.Windows.Forms.Padding(2);
            this.editSelectedGlyphButton.Name = "editSelectedGlyphButton";
            this.editSelectedGlyphButton.Size = new System.Drawing.Size(105, 24);
            this.editSelectedGlyphButton.TabIndex = 1;
            this.editSelectedGlyphButton.Text = "Edit Selected";
            this.editSelectedGlyphButton.UseVisualStyleBackColor = true;
            this.editSelectedGlyphButton.Click += new System.EventHandler(this.OnEditSelectedGlyphButtonClick);
            // 
            // addNewGlyphButton
            // 
            this.addNewGlyphButton.Location = new System.Drawing.Point(4, 17);
            this.addNewGlyphButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNewGlyphButton.Name = "addNewGlyphButton";
            this.addNewGlyphButton.Size = new System.Drawing.Size(98, 24);
            this.addNewGlyphButton.TabIndex = 1;
            this.addNewGlyphButton.Text = "Add New Glyph";
            this.addNewGlyphButton.UseVisualStyleBackColor = true;
            this.addNewGlyphButton.Click += new System.EventHandler(this.OnAddNewGlyphButtonClick);
            // 
            // fileManagmentGroupBox
            // 
            this.fileManagmentGroupBox.Controls.Add(this.loadGlyphsFileButton);
            this.fileManagmentGroupBox.Controls.Add(this.saveChangesButton);
            this.fileManagmentGroupBox.Controls.Add(this.discardChangesButton);
            this.fileManagmentGroupBox.Location = new System.Drawing.Point(4, 5);
            this.fileManagmentGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileManagmentGroupBox.Name = "fileManagmentGroupBox";
            this.fileManagmentGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.fileManagmentGroupBox.Size = new System.Drawing.Size(460, 50);
            this.fileManagmentGroupBox.TabIndex = 2;
            this.fileManagmentGroupBox.TabStop = false;
            this.fileManagmentGroupBox.Text = "File Managment";
            // 
            // loadGlyphsFileButton
            // 
            this.loadGlyphsFileButton.Location = new System.Drawing.Point(4, 17);
            this.loadGlyphsFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadGlyphsFileButton.Name = "loadGlyphsFileButton";
            this.loadGlyphsFileButton.Size = new System.Drawing.Size(98, 24);
            this.loadGlyphsFileButton.TabIndex = 0;
            this.loadGlyphsFileButton.Text = "Load Glyphs File";
            this.loadGlyphsFileButton.UseVisualStyleBackColor = true;
            this.loadGlyphsFileButton.Click += new System.EventHandler(this.OnLoadGmtFilesButtonClick);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(106, 17);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(105, 24);
            this.saveChangesButton.TabIndex = 0;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.OnSaveChangesButtonClick);
            // 
            // discardChangesButton
            // 
            this.discardChangesButton.Location = new System.Drawing.Point(216, 17);
            this.discardChangesButton.Margin = new System.Windows.Forms.Padding(2);
            this.discardChangesButton.Name = "discardChangesButton";
            this.discardChangesButton.Size = new System.Drawing.Size(105, 24);
            this.discardChangesButton.TabIndex = 0;
            this.discardChangesButton.Text = "Discard Changes";
            this.discardChangesButton.UseVisualStyleBackColor = true;
            this.discardChangesButton.Click += new System.EventHandler(this.OnDiscardChangesButtonClick);
            // 
            // manageWeapons
            // 
            this.manageWeapons.Location = new System.Drawing.Point(4, 22);
            this.manageWeapons.Margin = new System.Windows.Forms.Padding(2);
            this.manageWeapons.Name = "manageWeapons";
            this.manageWeapons.Padding = new System.Windows.Forms.Padding(2);
            this.manageWeapons.Size = new System.Drawing.Size(336, 600);
            this.manageWeapons.TabIndex = 1;
            this.manageWeapons.Text = "Manage Weapons";
            this.manageWeapons.UseVisualStyleBackColor = true;
            // 
            // loadGmtFilesInterface
            // 
            this.loadGmtFilesInterface.FileName = "gmt";
            // 
            // displayPanel
            // 
            this.displayPanel.AutoScroll = true;
            this.displayPanel.Location = new System.Drawing.Point(5, 159);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(459, 434);
            this.displayPanel.TabIndex = 5;
            // 
            // XmlManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 648);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "XmlManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML File Manager";
            this.Load += new System.EventHandler(this.XMLManagerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.manageGlyphs.ResumeLayout(false);
            this.narrowGlyphsByNameBox.ResumeLayout(false);
            this.narrowGlyphsByNameBox.PerformLayout();
            this.editGlyphsGroupBox.ResumeLayout(false);
            this.fileManagmentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage manageGlyphs;
        private System.Windows.Forms.TabPage manageWeapons;
        private System.Windows.Forms.Button discardChangesButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button editSelectedGlyphButton;
        private System.Windows.Forms.Button loadGlyphsFileButton;
        private System.Windows.Forms.OpenFileDialog loadGmtFilesInterface;
        private System.Windows.Forms.Button addNewGlyphButton;
        private System.Windows.Forms.GroupBox editGlyphsGroupBox;
        private System.Windows.Forms.GroupBox fileManagmentGroupBox;
        private System.Windows.Forms.Button deleteSelectedGlyphButton;
        private System.Windows.Forms.GroupBox narrowGlyphsByNameBox;
        private System.Windows.Forms.TextBox resultsNarrowBox;
        private System.Windows.Forms.Panel displayPanel;
    }
}

