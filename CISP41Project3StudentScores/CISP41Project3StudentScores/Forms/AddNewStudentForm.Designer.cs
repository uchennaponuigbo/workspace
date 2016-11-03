namespace CISP41Project3StudentScores
{
    partial class AddNewStudentForm
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.addScoreButton = new System.Windows.Forms.Button();
            this.clearScoresButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.scoresTextBox = new System.Windows.Forms.TextBox();
            this.validationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(25, 54);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(45, 17);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score";
            // 
            // scoresLabel
            // 
            this.scoresLabel.AutoSize = true;
            this.scoresLabel.Location = new System.Drawing.Point(25, 97);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(52, 17);
            this.scoresLabel.TabIndex = 2;
            this.scoresLabel.Text = "Scores";
            // 
            // addScoreButton
            // 
            this.addScoreButton.Location = new System.Drawing.Point(244, 50);
            this.addScoreButton.Name = "addScoreButton";
            this.addScoreButton.Size = new System.Drawing.Size(112, 31);
            this.addScoreButton.TabIndex = 3;
            this.addScoreButton.Text = "Add Score";
            this.addScoreButton.UseVisualStyleBackColor = true;
            this.addScoreButton.Click += new System.EventHandler(this.addScoreButton_Click);
            // 
            // clearScoresButton
            // 
            this.clearScoresButton.Location = new System.Drawing.Point(243, 142);
            this.clearScoresButton.Name = "clearScoresButton";
            this.clearScoresButton.Size = new System.Drawing.Size(113, 29);
            this.clearScoresButton.TabIndex = 4;
            this.clearScoresButton.Text = "Clear Scores";
            this.clearScoresButton.UseVisualStyleBackColor = true;
            this.clearScoresButton.Click += new System.EventHandler(this.clearScoresButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(123, 193);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(102, 29);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(244, 193);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 29);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(97, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(259, 22);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(97, 54);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(128, 22);
            this.scoreTextBox.TabIndex = 8;
            // 
            // scoresTextBox
            // 
            this.scoresTextBox.Location = new System.Drawing.Point(97, 94);
            this.scoresTextBox.Name = "scoresTextBox";
            this.scoresTextBox.ReadOnly = true;
            this.scoresTextBox.Size = new System.Drawing.Size(260, 22);
            this.scoresTextBox.TabIndex = 9;
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.ForeColor = System.Drawing.Color.Red;
            this.validationLabel.Location = new System.Drawing.Point(25, 142);
            this.validationLabel.MaximumSize = new System.Drawing.Size(200, 50);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(0, 17);
            this.validationLabel.TabIndex = 10;
            // 
            // AddNewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 253);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.scoresTextBox);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.clearScoresButton);
            this.Controls.Add(this.addScoreButton);
            this.Controls.Add(this.scoresLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddNewStudentForm";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoresLabel;
        private System.Windows.Forms.Button addScoreButton;
        private System.Windows.Forms.Button clearScoresButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.TextBox scoresTextBox;
        private System.Windows.Forms.Label validationLabel;
    }
}