using StudentNamespace;
using System;

namespace ModifiersAnotherAssembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.publicField = 5;
        }
    }

    class Course2
    {
        public Student MyProperty { get; set; }
    }
}
