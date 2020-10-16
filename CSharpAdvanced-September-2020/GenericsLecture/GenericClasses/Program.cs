using System;
using System.Collections.Generic;

namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<GenericList<int>> list = new GenericList<int>();
            var newVariable = list.GetElement(0);
            list.Add(5);
            list.Add(6);
            GenericList<string> stringList = new GenericList<string>();
            var newVariable2 = stringList.GetElement(0);

            stringList.Add("55");
            stringList.Add("hey");


            object everything;
            everything = 5;
            everything = new string[5];
            ObjectList studentNames = new ObjectList();
            studentNames.Add("pesho");
            studentNames.Add(5);
            studentNames.Add(6);
            studentNames.Add("55");
            studentNames.Add(new Program());
        }
    }

    class Student
    {
        public int Age { get; set; }

        public string Name { get; set; }
    }
}
