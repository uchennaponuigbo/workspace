namespace CISP41Project3StudentScores
{
    partial class StudentScoresForm
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
            this.studentsLabel = new System.Windows.Forms.Label();
            this.studentScoresScoreTotalLabel = new System.Windows.Forms.Label();
            this.studentScoresScoreCountLabel = new System.Windows.Forms.Label();
            this.studentScoresAverageLabel = new System.Windows.Forms.Label();
            this.addNewButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.scoresTotalTextBox = new System.Windows.Forms.TextBox();
            this.scoresCountTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.studentScoresListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Location = new System.Drawing.Point(21, 20);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(64, 17);
            this.studentsLabel.TabIndex = 0;
            this.studentsLabel.Text = "Students";
            // 
            // studentScoresScoreTotalLabel
            // 
            this.studentScoresScoreTotalLabel.AutoSize = true;
            this.studentScoresScoreTotalLabel.Location = new System.Drawing.Point(250, 228);
            this.studentScoresScoreTotalLabel.Name = "studentScoresScoreTotalLabel";
            this.studentScoresScoreTotalLabel.Size = new System.Drawing.Size(80, 17);
            this.studentScoresScoreTotalLabel.TabIndex = 1;
            this.studentScoresScoreTotalLabel.Text = "Score total:";
            // 
            // studentScoresScoreCountLabel
            // 
            this.studentScoresScoreCountLabel.AutoSize = true;
            this.studentScoresScoreCountLabel.Location = new System.Drawing.Point(242, 263);
            this.studentScoresScoreCountLabel.Name = "studentScoresScoreCountLabel";
            this.studentScoresScoreCountLabel.Size = new System.Drawing.Size(88, 17);
            this.studentScoresScoreCountLabel.TabIndex = 2;
            this.studentScoresScoreCountLabel.Text = "Score count:";
            // 
            // studentScoresAverageLabel
            // 
            this.studentScoresAverageLabel.AutoSize = true;
            this.studentScoresAverageLabel.Location = new System.Drawing.Point(265, 298);
            this.studentScoresAverageLabel.Name = "studentScoresAverageLabel";
            this.studentScoresAverageLabel.Size = new System.Drawing.Size(65, 17);
            this.studentScoresAverageLabel.TabIndex = 3;
            this.studentScoresAverageLabel.Text = "Average:";
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(428, 53);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(154, 30);
            this.addNewButton.TabIndex = 4;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(428, 89);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(154, 28);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(428, 123);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 31);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // scoresTotalTextBox
            // 
            this.scoresTotalTextBox.Location = new System.Drawing.Point(336, 228);
            this.scoresTotalTextBox.Name = "scoresTotalTextBox";
            this.scoresTotalTextBox.ReadOnly = true;
            this.scoresTotalTextBox.Size = new System.Drawing.Size(72, 22);
            this.scoresTotalTextBox.TabIndex = 7;
            // 
            // scoresCountTextBox
            // 
            this.scoresCountTextBox.Location = new System.Drawing.Point(336, 263);
            this.scoresCountTextBox.Name = "scoresCountTextBox";
            this.scoresCountTextBox.ReadOnly = true;
            this.scoresCountTextBox.Size = new System.Drawing.Size(72, 22);
            this.scoresCountTextBox.TabIndex = 8;
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(336, 298);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.ReadOnly = true;
            this.averageTextBox.Size = new System.Drawing.Size(72, 22);
            this.averageTextBox.TabIndex = 9;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(428, 280);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 35);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // studentScoresListBox
            // 
            this.studentScoresListBox.FormattingEnabled = true;
            this.studentScoresListBox.ItemHeight = 16;
            this.studentScoresListBox.Location = new System.Drawing.Point(24, 53);
            this.studentScoresListBox.Name = "studentScoresListBox";
            this.studentScoresListBox.Size = new System.Drawing.Size(384, 148);
            this.studentScoresListBox.TabIndex = 11;
            this.studentScoresListBox.SelectedIndexChanged += new System.EventHandler(this.studentScoresListBox_SelectedIndexChanged);
            // 
            // StudentScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 353);
            this.Controls.Add(this.studentScoresListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.scoresCountTextBox);
            this.Controls.Add(this.scoresTotalTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.studentScoresAverageLabel);
            this.Controls.Add(this.studentScoresScoreCountLabel);
            this.Controls.Add(this.studentScoresScoreTotalLabel);
            this.Controls.Add(this.studentsLabel);
            this.Name = "StudentScoresForm";
            this.Text = "Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.Label studentScoresScoreTotalLabel;
        private System.Windows.Forms.Label studentScoresScoreCountLabel;
        private System.Windows.Forms.Label studentScoresAverageLabel;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox scoresTotalTextBox;
        private System.Windows.Forms.TextBox scoresCountTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox studentScoresListBox;
    }
}

