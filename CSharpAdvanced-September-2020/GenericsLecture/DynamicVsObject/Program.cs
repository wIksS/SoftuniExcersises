using System;
using System.Collections.Generic;

namespace DynamicVsObject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x = 5;

            List<List<int>> newList = x.SomeMethod();

            int result = x.CallWhatever();

            object y = 5;
        }
    }
}
