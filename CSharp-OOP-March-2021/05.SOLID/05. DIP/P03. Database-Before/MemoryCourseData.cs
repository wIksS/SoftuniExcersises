using P03._Database_Before.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03._Database_Before
{
    class MemoryCourseData : ICourseData
    {
        private List<Course> courses;

        public MemoryCourseData()
        {
            courses = new List<Course>()
            {
                new Course(){Id=5, Name="C# OOP"},
                new Course(){Id=1, Name="C# Advanced"},
                new Course(){Id=2, Name="C#"},
                new Course(){Id=3, Name="Astrologiq"},
            };
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
