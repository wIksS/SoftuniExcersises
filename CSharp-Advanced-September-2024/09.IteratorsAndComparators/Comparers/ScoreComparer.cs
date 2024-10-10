using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
    public class ScoreComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return y.Score.CompareTo(x.Score);   
        }
    }
}
