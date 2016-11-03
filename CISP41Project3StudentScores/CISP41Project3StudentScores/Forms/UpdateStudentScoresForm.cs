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
    public partial class UpdateStudentScoresForm : Form
    {
        private List<int> _scores;
        private int _selectedScoreIndex;

        public int SelectedScore
        {
            get;
            set;
        }

        public UpdateStudentScoresForm()
        {
            InitializeComponent();

            nameTextBox.Text = StudentService.SelectedStudent.Name;
            _scores = new List<int>();
            _scores.AddRange(StudentService.SelectedStudent.Scores);

            refreshScoresDisplay();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addScoreForm = new AddScoreForm();
            addScoreForm.ShowDialog(this);
            if (addScoreForm.HasScore)
            {
                _scores.Add(addScoreForm.SelectedScore);
                refreshScoresDisplay();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!_scores.Any() || scoresListBox.SelectedIndex < 0)
            {
                return;
            }

            using (var updateScoreForm = new UpdateScoreForm(SelectedScore))
            {
                updateScoreForm.ShowDialog(this);
                if (updateScoreForm.HasScore)
                {
                    _scores[_selectedScoreIndex] = updateScoreForm.SelectedScore;
                    refreshScoresDisplay();
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!_scores.Any() || scoresListBox.SelectedIndex < 0)
            {
                return;
            }

            _scores.RemoveAt(_selectedScoreIndex);
            refreshScoresDisplay();
        }

        private void clearScoresButton_Click(object sender, EventArgs e)
        {
            _scores.Clear();
            refreshScoresDisplay();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            StudentService.SelectedStudent.Scores = _scores;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void scoresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_scores.Any() || scoresListBox.SelectedIndex < 0)
            {
                return;
            }
            _selectedScoreIndex = scoresListBox.SelectedIndex;
            SelectedScore = _scores[_selectedScoreIndex];
        }

        private void refreshScoresDisplay()
        {
            scoresListBox.Items.Clear();
            foreach (var score in _scores)
            {
                scoresListBox.Items.Add(score);
            }
        }
    }
}
