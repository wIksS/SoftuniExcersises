using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Dimi",17);

            Console.WriteLine($"Student: {student.Name}, {student.Age}, ID: {student.Id}");

            Student student2 = new Student("Pesho");

            Console.WriteLine($"Student: {student2.Name}, {student2.Age}, ID: {student2.Id}");
        }
    }
}
