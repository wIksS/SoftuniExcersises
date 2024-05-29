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
            //PrintMethodsByType(typeof(StartUp));
        }

        //private void PrintMethodsByType(Type type)
        //{
        //    MethodInfo[] methods = type.GetMethods();
        //    foreach (var method in methods)
        //    {
        //        List<AuthorAttribute> attributes = method.GetCustomAttributes<AuthorAttribute>().ToList();
        //        if (attributes.Count > 0)
        //        {
        //            foreach (AuthorAttribute attr in attributes)
        //            {
        //                Console.WriteLine($"{method.Name} is written by {attr.Name}");
        //            }
        //        }

        //    }

        //}
    }
}
