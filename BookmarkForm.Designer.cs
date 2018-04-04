namespace Practice_2__Local_Web_Bookmark
{
    partial class BookmarkForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkForm));
            this.WebListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Addbutton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.txtWebLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.filenamelabel = new System.Windows.Forms.Label();
            this.filedisplaylabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateSavedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ellilpsisButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebListBox
            // 
            this.WebListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.WebListBox.FormattingEnabled = true;
            this.WebListBox.Location = new System.Drawing.Point(11, 133);
            this.WebListBox.Name = "WebListBox";
            this.WebListBox.Size = new System.Drawing.Size(513, 147);
            this.WebListBox.TabIndex = 0;
            this.WebListBox.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            this.WebListBox.SelectedIndexChanged += new System.EventHandler(this.WebListBox_SelectedIndexChanged);
            this.WebListBox.DoubleClick += new System.EventHandler(this.WebListBox_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.visitURLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
            this.contextMenuStrip1.Text = "Copy";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // visitURLToolStripMenuItem
            // 
            this.visitURLToolStripMenuItem.Name = "visitURLToolStripMenuItem";
            this.visitURLToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.visitURLToolStripMenuItem.Text = "Visit URL";
            this.visitURLToolStripMenuItem.Click += new System.EventHandler(this.visitURLToolStripMenuItem_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(12, 43);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 1;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DeleteButton.Location = new System.Drawing.Point(12, 73);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 103);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // txtWebLink
            // 
            this.txtWebLink.Location = new System.Drawing.Point(96, 42);
            this.txtWebLink.Name = "txtWebLink";
            this.txtWebLink.Size = new System.Drawing.Size(428, 20);
            this.txtWebLink.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a website link or any other text needed.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filenamelabel
            // 
            this.filenamelabel.AutoSize = true;
            this.filenamelabel.Location = new System.Drawing.Point(6, 5);
            this.filenamelabel.Name = "filenamelabel";
            this.filenamelabel.Size = new System.Drawing.Size(57, 13);
            this.filenamelabel.TabIndex = 8;
            this.filenamelabel.Text = "File Name:";
            // 
            // filedisplaylabel
            // 
            this.filedisplaylabel.AutoSize = true;
            this.filedisplaylabel.Location = new System.Drawing.Point(60, 5);
            this.filedisplaylabel.Name = "filedisplaylabel";
            this.filedisplaylabel.Size = new System.Drawing.Size(27, 13);
            this.filedisplaylabel.TabIndex = 9;
            this.filedisplaylabel.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lines:";
            // 
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.Location = new System.Drawing.Point(38, 30);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(13, 13);
            this.numberlabel.TabIndex = 12;
            this.numberlabel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateSavedLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ellilpsisButton);
            this.groupBox1.Controls.Add(this.filenamelabel);
            this.groupBox1.Controls.Add(this.numberlabel);
            this.groupBox1.Controls.Add(this.filedisplaylabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(96, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 58);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // DateSavedLabel
            // 
            this.DateSavedLabel.AutoSize = true;
            this.DateSavedLabel.Location = new System.Drawing.Point(156, 30);
            this.DateSavedLabel.Name = "DateSavedLabel";
            this.DateSavedLabel.Size = new System.Drawing.Size(27, 13);
            this.DateSavedLabel.TabIndex = 15;
            this.DateSavedLabel.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Saved On:";
            // 
            // ellilpsisButton
            // 
            this.ellilpsisButton.Location = new System.Drawing.Point(397, 30);
            this.ellilpsisButton.Name = "ellilpsisButton";
            this.ellilpsisButton.Size = new System.Drawing.Size(25, 22);
            this.ellilpsisButton.TabIndex = 13;
            this.ellilpsisButton.Text = "...";
            this.ellilpsisButton.UseVisualStyleBackColor = true;
            this.ellilpsisButton.Click += new System.EventHandler(this.ellilpsisButton_Click);
            // 
            // BookmarkForm
            // 
            this.AcceptButton = this.Addbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DeleteButton;
            this.ClientSize = new System.Drawing.Size(536, 287);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWebLink);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.WebListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookmarkForm";
            this.Text = "Bookmarks";
            this.Load += new System.EventHandler(this.Bookmark_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WebListBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox txtWebLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitURLToolStripMenuItem;
        private System.Windows.Forms.Label filenamelabel;
        private System.Windows.Forms.Label filedisplaylabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ellilpsisButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DateSavedLabel;
    }
}

