using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    public class University
    {
        public University()
        {
            Students = new List<Student>();
        }
        
        public List<Student> Students { get; set; }

        public void RegisterStudent(Student student)
        {
            if (student.Age < 12)
            {
                throw new ArgumentException("Students below 12 years should not be registered for university");
            }

            Students.Add(student);
        }

        public Student FindStudent(int id)
        {
            return Students.First(s => s.Id == id);
        }

        public List<Student> FindStudent(string name)
        {
            return Students.Where(s => s.Name.Contains(name)).ToList();
        }
    }
}
