using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncsUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Split().Select(int.Parse)

            int[] array = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(String.Join(" ", 
                Where(array, IsNumberMagical)
                ));
            
            ReadStudents((name, age) =>
            {
                Console.WriteLine("In lambda ");
                return $"Lambdas are cuul {name}{age}";
            });
        }

        static bool IsNumberMagical(int number)
        {
            if (number == 42)
            {
                return true;
            }

            return false;
        }

        static int[] Where(int[] array, Func<int, bool> condition)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (condition(array[i]))
                {
                    list.Add(array[i]);
                }
            }

            return list.ToArray();
        }

        static void ReadStudents(Func<string, int, string> printer)
        {

            int age = 0;
            do
            {
                Console.WriteLine("Student name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Student age: ");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine(printer(name, age));

            } while (age != -1);
        }

        static string PrintStudentDvoikadjiq(string name, int age)
        {
            return $"2";
        }

        static string PrintStudentBulgarian(string name, int age)
        {
            return $"Bulgarian student is {age} and named {name}";
        }

        static string PrintStudentSoftuni(string name, int age)
        {
            return $"Softuni student is {age} and named {name}";
        }
    }
}
