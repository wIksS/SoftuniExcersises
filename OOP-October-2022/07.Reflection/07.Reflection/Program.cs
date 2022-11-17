using System;
using System.Collections.Generic;
using System.Reflection;

namespace _07.Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Name="Dimitrichko",Age=45,Score=6};
            PrintProperties(DateTime.Now);
            Console.WriteLine();

            PrintProperties(student);

        }

        public static void PrintProperties(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.Name} : {property.GetValue(obj)}");
            }
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
