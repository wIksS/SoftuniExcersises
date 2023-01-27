using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public double AverageGrade { get; set; }

        public List<Course> Courses { get; set; }

        public void AddCourse(Course course, double grade)
        {
            Courses.Add(course);

            // recalculate averageGrade


        }
    }
}
