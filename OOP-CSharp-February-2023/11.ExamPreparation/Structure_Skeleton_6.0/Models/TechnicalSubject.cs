using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCompetition.Models
{
    public class TechnicalSubject : Subject
    {
        public TechnicalSubject(int subjectId, string subjectName) : base(subjectId, subjectName, 1.3)
        {
        }
    }
}
