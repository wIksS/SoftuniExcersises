using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            PrintGrade(grade);
        }

        static void PrintGrade(double grade)
        {
            if (grade > 2 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
