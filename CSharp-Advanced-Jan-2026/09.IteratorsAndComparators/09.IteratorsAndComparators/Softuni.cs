//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _09.IteratorsAndComparators
//{
//    public class Softuni : IEnumerable<string>
//    {
//        public IEnumerator<string> GetEnumerator()
//        {
//            string[] array = ["C# Advanced", "C# OOP", "Javascript", "Databases"];
//            foreach (var item in array)
//            {
//                yield return item;
//            }

//            //return new ListyIterator<string>(
//            //    ["C# Advanced", "C# OOP", "Javascript", "Databases"]);
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }
//    }
//}
