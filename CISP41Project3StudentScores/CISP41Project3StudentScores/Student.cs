using System;
using System.Collections.Generic;

namespace CISP41Project3StudentScores
{
    public class Student
    {
        private List<int> _scores = new List<int>();
        public string Name
        {
            get;
            set;
        }

        public List<int> Scores
        {
            get
            {
                return _scores;
            }
            set
            {
                _scores.Clear();
                _scores.AddRange(value);
            }

        }

        public string DisplayData
        {
            get
            {
                return StudentService.DisplayStudentData(this);
            }
        }
    }
}
