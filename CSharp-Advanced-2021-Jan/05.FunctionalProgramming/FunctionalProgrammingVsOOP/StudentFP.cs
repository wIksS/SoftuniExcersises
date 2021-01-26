using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingVsOOP
{
    public class StudentFP
    {
        public bool IsHoliday(DateTime today)
        {
            if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }

            return false;
        }

        public Student[] RemoveDumbStudents(Student[] students)
        {
            List<Student> smartStudents = new List<Student>();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].AverageGrade >= 4)
                {
                    smartStudents.Add(students[i]);
                }
            }

            return smartStudents.ToArray();
        }
    }
}
