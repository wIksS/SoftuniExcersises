using System;

namespace JavaGetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.SetName(Console.ReadLine());

            Console.WriteLine(student.GetName());
        }
    }
}
