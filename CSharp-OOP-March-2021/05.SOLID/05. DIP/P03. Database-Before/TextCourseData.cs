using P03._Database_Before.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P03._Database_Before
{
    class TextCourseData : ICourseData
    {
        private List<Course> courses;

        public TextCourseData(string textLocation)
        {
            courses = new List<Course>();
            using (StreamReader reader = new StreamReader(textLocation))
            {
                var text = reader.ReadLine();
                while (text != null)
                {
                    var data = text.Split(",");
                    courses.Add(new Course() { Id = int.Parse(data[0]), Name = data[1] });
                    text = reader.ReadLine();
                }

            }
        }

        public IEnumerable<int> CourseIds()
        {
            return courses.Select(c => c.Id);
        }

        public IEnumerable<string> CourseNames()
        {
            return courses.Select(c => c.Name);
        }

        public string GetCourseById(int id)
        {
            return courses.First(c => c.Id == id).Name;
        }
    }
}
