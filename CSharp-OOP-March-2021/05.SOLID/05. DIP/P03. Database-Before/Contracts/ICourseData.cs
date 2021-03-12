using System;
using System.Collections.Generic;
using System.Text;

namespace P03._Database_Before.Contracts
{
    public interface ICourseData
    {
        IEnumerable<int> CourseIds();

        IEnumerable<string> CourseNames();

        public string GetCourseById(int id);

    }
}
