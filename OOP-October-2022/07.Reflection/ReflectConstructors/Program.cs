using System;
using System.Reflection;

namespace ReflectConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorInfo[] constructors = typeof(Student).GetConstructors();

            Console.WriteLine(constructors.Length);
            foreach (ConstructorInfo constructor in constructors)
            {
                ParameterInfo[] parameters = constructor.GetParameters();

                Console.WriteLine($"Parameter count: {parameters.Length}");
                object[] constructorParams = new object[parameters.Length];
                int index = 0;
                foreach (ParameterInfo parameter in parameters)
                {
                    constructorParams[index++] = GetDefaultValue(parameter.ParameterType);
                    Console.WriteLine($"{parameter.Name}, {parameter.ParameterType.Name}");
                }

                object instance = constructor.Invoke(constructorParams);
            }
        }

        static object GetDefaultValue(Type t)
        {
            if (t.IsValueType)
                return Activator.CreateInstance(t);

            return null;
        }
    }

    class Student
    {
        public Student()
        {
            Console.WriteLine("Empty");
        }

        public Student(string name, int age)
        {
            Console.WriteLine("With name");

            Name = name;
        }
        public string Name { get; set; }
    }
}
