namespace CISP41Project3StudentScores
{
    partial class UpdateStudentScoresForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearScoresButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.scoresListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // scoresLabel
            // 
            this.scoresLabel.AutoSize = true;
            this.scoresLabel.Location = new System.Drawing.Point(13, 44);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(56, 17);
            this.scoresLabel.TabIndex = 1;
            this.scoresLabel.Text = "Scores:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(282, 44);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 31);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(282, 94);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(126, 31);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(282, 142);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(126, 31);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearScoresButton
            // 
            this.clearScoresButton.Location = new System.Drawing.Point(282, 193);
            this.clearScoresButton.Name = "clearScoresButton";
            this.clearScoresButton.Size = new System.Drawing.Size(126, 31);
            this.clearScoresButton.TabIndex = 5;
            this.clearScoresButton.Text = "Clear Scores";
            this.clearScoresButton.UseVisualStyleBackColor = true;
            this.clearScoresButton.Click += new System.EventHandler(this.clearScoresButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(131, 268);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(126, 31);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(282, 268);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 31);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(78, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(330, 22);
            this.nameTextBox.TabIndex = 8;
            // 
            // scoresListBox
            // 
            this.scoresListBox.FormattingEnabled = true;
            this.scoresListBox.ItemHeight = 16;
            this.scoresListBox.Location = new System.Drawing.Point(78, 44);
            this.scoresListBox.Name = "scoresListBox";
            this.scoresListBox.Size = new System.Drawing.Size(179, 180);
            this.scoresListBox.TabIndex = 9;
            this.scoresListBox.SelectedIndexChanged += new System.EventHandler(this.scoresListBox_SelectedIndexChanged);
            // 
            // UpdateStudentScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 332);
            this.Controls.Add(this.scoresListBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.clearScoresButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.scoresLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "UpdateStudentScoresForm";
            this.Text = "UpdateStudentScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label scoresLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearScoresButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListBox scoresListBox;
    }
}