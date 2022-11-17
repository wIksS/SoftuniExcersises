using System;
using System.Collections.Generic;

namespace ActivatorCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine(list);
            Console.WriteLine("What class would you like to create?");

            Type type = Type.GetType(Console.ReadLine());

            object obj = CreateObjectByType(type);
            DateTime datetime = (DateTime)obj;
            Console.WriteLine(obj.ToString());

            //Type type = typeof(Student);
            //Student student = new Student("Dimitrichko");
            //Student reflectionStudent =
            //    (Student) 
            //    Activator.CreateInstance(type, new object[] { "Goshko", "2" });
        }

        public static object CreateObjectByType(Type type)
        {
            Object createdObj = Activator.CreateInstance(type);

            return createdObj;
        }
    }

    class Student
    {
        public Student(string name)
        {
            Name = name;
            Console.WriteLine($"Initializing {name}");
        }
        public string Name { get; set; }
    }
}
