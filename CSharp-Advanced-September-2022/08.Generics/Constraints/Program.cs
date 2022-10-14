using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Constraints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GenericList<StreamReader> list;// = new GenericList<Student>();

           // list.Print(5);
            //list.Print("");
        }
    }

    class GenericList<T> where T : MarshalByRefObject?
    {
        public void Print<T1>(T1 element) where T1 : T
        {
            Console.WriteLine(element);
        }
    }

    class Student
    {
        public Student(int x)
        {
            Console.WriteLine();
        }

        public Student()
        {

        }
    }
}
