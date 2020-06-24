using System;

namespace ClassesAndObjects
{
    class Program
    {
        // Student
        //      name -> string
        //      age -> int
        //      skills -> string[]
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter years: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter skills: ");
            string[] skills = Console.ReadLine().Split();

            PrintStudent(name, age, skills);
        }

        static void PrintStudent(string name, int age, string[] skills)
        {
            Console.WriteLine
                ($"Student name->{name};age -> {age}; skills -> {String.Join(",", skills)}");
        }
    }
}
