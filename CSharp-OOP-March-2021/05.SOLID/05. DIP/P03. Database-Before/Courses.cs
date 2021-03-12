using P03._Database_Before.Contracts;

namespace P03._Database
{
    public class Courses
    {
        private ICourseData coursesDatabase;

        public Courses(ICourseData courseData)
        {
            coursesDatabase = courseData;
        }

        public void PrintAll()
        {
            var courses = coursesDatabase.CourseNames();

            System.Console.WriteLine(string.Join(",", courses));
        }

        public void PrintIds()
        {
            var courseIds = coursesDatabase.CourseIds();

            System.Console.WriteLine(string.Join(",", courseIds));
        }

        public void PrintById(int id)
        {
            var course = coursesDatabase.GetCourseById(id);

            System.Console.WriteLine(course);
        }
    }
}
