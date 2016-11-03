using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISP41Project3StudentScores
{
    public partial class AddNewStudentForm : Form
    {
        public AddNewStudentForm()
        {
            InitializeComponent();
        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {
            validationLabel.Text = "";

            int score;
            var scoreIsValid = int.TryParse(scoreTextBox.Text, out score);
            if(!scoreIsValid)
            {
                validationLabel.Text = "Please enter a valid score between 0 and 100";
            }
            else if (0 > score || score > 100)
            {
                validationLabel.Text = "Please enter a valid score between 0 and 100";                
            }
            else
            {
                scoresTextBox.Text = scoresTextBox.Text + score.ToString() + " ";
                scoreTextBox.Text = "";
            }            
        }

        private void clearScoresButton_Click(object sender, EventArgs e)
        {
            scoreTextBox.Text = "";
            scoresTextBox.Text = "";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            validationLabel.Text = "";
            if(string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                validationLabel.Text = "Please enter a valid name.";
            }
            else
            {
                var scores = scoresTextBox.Text
                    .ToString()
                    .Split(' ')
                    .Where(score => !string.IsNullOrWhiteSpace(score))
                    .Select(score => int.Parse(score))
                    .ToList();

                var student = StudentService.CreateStudent(nameTextBox.Text);
                scores.ForEach(score => StudentService.AddScore(student, score));
                
                StudentService.Students.AddStudent(student);
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            validationLabel.Text = "";
        }
    }
}
