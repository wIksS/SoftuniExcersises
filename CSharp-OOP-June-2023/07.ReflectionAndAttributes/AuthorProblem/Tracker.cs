using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass).ToArray();
            foreach (Type type in types)
            {
                MethodInfo[] methods = type.GetMethods((BindingFlags)60);

                foreach (MethodInfo method in methods)
                {
                    AuthorAttribute[] attributes = method.GetCustomAttributes<AuthorAttribute>().ToArray();
                    foreach (var attribute in attributes)
                    {
                        Console.WriteLine($"{type.Name} -> {method.Name} is written by {attribute.Name}");
                    }
                }
            }
     
        }
    }
}
