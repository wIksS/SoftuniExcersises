using System;
using System.Collections.Generic;

namespace TypeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(DayOfWeek);

            Console.WriteLine($"Base type: {type.BaseType.Name}");
            Console.WriteLine($"Name : {type.Name}");
            Console.WriteLine($"Assembly : {type.Assembly}");
            Console.WriteLine($"IsAbstract : {type.IsAbstract}");
            Console.WriteLine($"IsEnum : {type.IsEnum}");
            Console.WriteLine($"Namespace : {type.Namespace}");
            Console.WriteLine($"IsClass : {type.IsClass}");


        }
    }

    abstract class Student : List<int>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Score { get; set; }

        public Student Friend { get; set; }
    }
}
