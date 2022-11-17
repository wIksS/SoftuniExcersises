using System;
using System.Reflection;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Name="Pesho"};

            Type type = student.GetType();

            MethodInfo[] methods = type.GetMethods();
            MethodInfo method = methods[0];
            ParameterInfo[] parameters = method.GetParameters();

            Console.WriteLine($"Parameters count: {parameters.Length}");

            method.Invoke(student,new object[] { 5});
        }
    }

    class Student
    {
        public string Name { get; set; }

        public void Greet(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"Hello my name is {Name}");
            }
        }
    }
}
