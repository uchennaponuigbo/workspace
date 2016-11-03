using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISP41Project3StudentScores
{
    public static class StudentService
    {
        public static readonly List<Student> Students = new List<Student>();
        public static Student SelectedStudent;
        static StudentService()
        {
            var sampleStudent1 = CreateStudent("Joel Murach")
                .AddScore(97)
                .AddScore(71)
                .AddScore(83);

            var sampleStudent2 = CreateStudent("Doug Lowe")
                .AddScore(99)
                .AddScore(93)
                .AddScore(97);

            var sampleStudent3 = CreateStudent("Anne Boehm")
                .AddScore(100)
                .AddScore(100)
                .AddScore(100);

            Students
                .AddStudent(sampleStudent1)
                .AddStudent(sampleStudent2)
                .AddStudent(sampleStudent3);
        }

        public static Student CreateStudent(string name)
        {
            return new Student
            {
                Name = name,
                Scores = new List<int>()
            };
        }

        public static List<Student> AddStudent(this List<Student> students, Student student)
        {
            students.Add(student);
            return students;
        }

        public static Student AddScore(this Student student, int score)
        {
            if(student.Scores == null)
            {
                student.Scores = new List<int>();
            }
            student.Scores.Add(score);
            return student;
        }

        public static string DisplayStudentData(this Student student)
        {
            if(student.Scores.Any())
            {
                return student.Name + " | " + string.Join(" | ", student.Scores);
            }
            return student.Name;
        }

        public static Student GetStudent(string studentName)
        {
            return Students.FirstOrDefault(student => string.Equals(student.Name, studentName));
        }

        public static void DeleteStudent(string studentName)
        {
            var student = GetStudent(studentName);
            if (student == null)
                return;
            var index = Students.IndexOf(student);
            Students.RemoveAt(index);
        }

        public static Student GetStudentFromStudentData(string studentData)
        {
            var studentName = studentData.Split('|')[0].Trim();
            return GetStudent(studentName);
        }

        public static int GetTotalScore(this Student student)
        {
            if (!student.Scores.Any())
            {
                return 0;
            }

            return student.Scores
                .Aggregate((score, accum) =>
                {
                    return accum + score;
                });
        }

        public static int GetAverageScore(this Student student)
        {
            if(!student.Scores.Any())
            {
                return 0;
            }

            return student.GetTotalScore()/student.Scores.Count;
        }       
    }
}
