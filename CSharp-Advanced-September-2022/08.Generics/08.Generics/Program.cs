using System;
using System.Collections.Generic;

namespace _08.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            CustomList<int> customList = new CustomList<int>();
            CustomList<string> customListString = new CustomList<string>();
        }
    }



    class CustomList<T>
    {

    }
}
