using System;
using System.Reflection;
using System.Text;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type studentType = typeof(Student);

            Type[] interfaces = studentType.GetInterfaces();
            foreach (var type in interfaces)
            {
                Console.WriteLine(type.Name);
            }

            MethodInfo[] methods = studentType.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }


            return;
            Console.WriteLine("Which class do you want to inspect");
            string className = Console.ReadLine();
            Type stringBuilderType = Type.GetType(className);

            Console.WriteLine(stringBuilderType.AssemblyQualifiedName);
            Console.WriteLine(stringBuilderType.FullName);
            Console.WriteLine(stringBuilderType.Name);
            Console.WriteLine(stringBuilderType.BaseType);
        }
    }
}
