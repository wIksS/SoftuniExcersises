using System;
using System.Linq;
using System.Reflection;

namespace CustomAttributes
{
    internal class Program
    {
        // Mark all important methods and classes that the
        // documentation team has to document
        static void Main(string[] args)
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in types)
            {
                DocumentAttribute attr = type.GetCustomAttributes().FirstOrDefault(a => a.GetType() == typeof(DocumentAttribute)) as DocumentAttribute;
                if (attr != null)
                {
                    Console.WriteLine($"{type.Name} should be documented by {attr.DocumenterName}, criticality: {attr.Criticality}");

                    PrintNeededMethodDocumentations(type);
                }
            }
        }

        static void PrintNeededMethodDocumentations(Type type)
        {
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                DocumentAttribute attr = method.GetCustomAttributes().FirstOrDefault(a => a.GetType() == typeof(DocumentAttribute)) as DocumentAttribute;
                if (attr != null)
                {
                    Console.WriteLine($"Method {method.Name} should be documented by {attr.DocumenterName}, criticality:{attr.Criticality}");
                }
            }
        }
    }
}
