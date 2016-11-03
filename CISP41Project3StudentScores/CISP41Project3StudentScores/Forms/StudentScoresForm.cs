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
    public partial class StudentScoresForm : Form
    {
        public StudentScoresForm()
        {
            InitializeComponent();
            updateStudentsList(StudentService.Students);
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            var addNewStudentForm = new AddNewStudentForm();
            addNewStudentForm.ShowDialog();

            refreshFormDisplayData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var student = getSelectedStudent();
            if (student == null)
            {
                return;
            }

            StudentService.SelectedStudent = student;

            var updateStudentScoresForm = new UpdateStudentScoresForm();
            updateStudentScoresForm.ShowDialog();

            StudentService.SelectedStudent = null;

            refreshFormDisplayData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var student = getSelectedStudent();
            if(student == null)
            {
                return;
            }

            var dialogResult = MessageBox.Show("Are you sure you want to delete this student?", 
                "Confirm delete", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                StudentService.DeleteStudent(student.Name);
                student = null;
            };

            refreshFormDisplayData();
        }


        private void studentScoresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSelectdStudentInfo();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshFormDisplayData()
        {
            updateStudentsList(StudentService.Students);
            updateSelectdStudentInfo();
        }
        private void updateStudentsList(List<Student> students)
        {
            studentScoresListBox.Items.Clear();
            foreach (var student in students)
            {
                studentScoresListBox.Items.Add(student.DisplayData);
            }
        }

        private Student getSelectedStudent()
        {
            if (studentScoresListBox.SelectedIndex < 0)
                return null;
            var displayData = studentScoresListBox.Items[studentScoresListBox.SelectedIndex].ToString();
            return StudentService.GetStudentFromStudentData(displayData);
        }

        private void updateSelectdStudentInfo()
        {
            scoresTotalTextBox.Text = "";
            scoresCountTextBox.Text = "";
            averageTextBox.Text = "";

            var student = getSelectedStudent();
            if (student == null)
                return;

            var totalScore = student.GetTotalScore();
            var count = student.Scores.Count;
            var average = count > 0 ? (int)(totalScore / count) : 0;

            scoresTotalTextBox.Text = totalScore.ToString();
            scoresCountTextBox.Text = count.ToString();
            averageTextBox.Text = average.ToString();
        }
    }
}
