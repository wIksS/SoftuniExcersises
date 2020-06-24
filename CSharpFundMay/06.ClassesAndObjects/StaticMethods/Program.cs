using System;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student peshoStudent = Student.ReadStudent();
            Student gosho = Student.ReadStudent();
            Student viktor = new Student();
            peshoStudent.AgeStudent();
            gosho.AgeStudent();
            Student.PrintStudent(peshoStudent);

            Console.WriteLine(Student.StudentsCount);
        }
    }
}
