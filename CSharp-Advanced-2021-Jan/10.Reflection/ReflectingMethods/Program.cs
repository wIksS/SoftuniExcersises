using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ReflectingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MathsSoftuni);

            MethodInfo[] methods = type.GetMethods(BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static);

            MathsSoftuni math = new MathsSoftuni();

            foreach (MethodInfo method in methods)
            {
                ParameterInfo[] methodParamInfos = method.GetParameters();

                var methodParams = methodParamInfos
                    .Select(p => new KeyValuePair<string, string>
                    (p.Name, p.ParameterType.Name))
                    .ToList();

                Console.WriteLine($"{method.Name} -> {String.Join(",", methodParams)}");

                var inputParams = new object[] { 5, 6 };
                if (methodParamInfos.Length > 2)
                {
                    inputParams = new object[] { 5, 6, 7 };
                }

                int result = (int)method.Invoke(math, inputParams);
                Console.WriteLine(result);
            }
        }
    }
}
