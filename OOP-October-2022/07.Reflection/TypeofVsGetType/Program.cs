using System;

namespace TypeofVsGetType
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();

            //Type typeofType = typeof(Student);
            //Type type = student.GetType();

            PrintObjClassName(student);
            PrintObjClassName(DateTime.Now);
        }

        public static void PrintObjClassName(object obj)
        {
            Type type = obj.GetType();
            Console.WriteLine(type.Name);
        }
    }

    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Score { get; set; }

        public Student Friend { get; set; }
    }
}
