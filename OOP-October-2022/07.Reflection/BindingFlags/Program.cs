using System;
using System.Reflection;

namespace BindingFlagsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BindingFlags allFlags = (BindingFlags)60;
            Console.WriteLine(allFlags);
            FieldInfo[] fields = typeof(Student).GetFields((BindingFlags)60);

            Console.WriteLine(fields.Length);
        }
    }

    class Student
    {
        private int privateField = 1;
        protected string protectedField = "2";
        internal int internalField = 3;
        public int publicField = 4;

        public static int staticPublicField = 5;
    }
}
