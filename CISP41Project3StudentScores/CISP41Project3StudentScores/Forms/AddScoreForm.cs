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
    public partial class AddScoreForm : Form
    {
        public int SelectedScore
        {
            get;
            set;
        }

        public bool HasScore
        {
            get;
            set;
        }

        public AddScoreForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validationLabel.Text = "";

            int score;
            var scoreIsValid = int.TryParse(scoreTextBox.Text, out score);
            if (!scoreIsValid)
            {
                validationLabel.Text = "Please enter a valid score between 0 and 100";
            }
            else if (0 > score || score > 100)
            {
                validationLabel.Text = "Please enter a valid score between 0 and 100";
            }
            else
            {
                SelectedScore = score;
                HasScore = true;
                Close();
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            HasScore = false;
            Close();
        }
    }
}
