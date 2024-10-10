using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
    public class Student
    {
        public Student(string name, int score, string university)
        {
            Name = name;
            Score = score;
            University = university;
        }

        public string Name { get; set; }
        public int Score { get; set; }

        public string University{ get; set; }

    }
}