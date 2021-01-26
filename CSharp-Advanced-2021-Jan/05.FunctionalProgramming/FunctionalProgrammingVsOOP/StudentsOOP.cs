using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgrammingVsOOP
{
    public class StudentsOOP
    {
        public bool IsHoliday()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }

            return false;
        }

        public void SortStudents(Student[] students)
        {
            Array.Sort(students);
        }

        public void RemoveDumbStudents(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].AverageGrade < 4)
                {
                    students[i] = null;
                }
            }
        }

    }
}
