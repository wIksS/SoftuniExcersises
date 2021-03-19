using System;
using System.Reflection;

namespace ReflectingConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Student);

            ConstructorInfo concreteConstructor = type.GetConstructor(
                new Type[] { typeof(String), typeof(string) });

            ConstructorInfo[] constructors = type.GetConstructors();

            foreach (var constructor in constructors)
            {
                ParameterInfo[] paramInfos = constructor.GetParameters();
            }
        }
    }
}
