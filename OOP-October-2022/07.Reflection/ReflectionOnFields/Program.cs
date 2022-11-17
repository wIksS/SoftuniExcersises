using System;
using System.Reflection;

namespace ReflectionOnFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.publicField = 25555;
            Student student2 = new Student();

            Type type = student.GetType();

            FieldInfo[] fields = type.GetFields(
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);

            //FieldInfo field = fields[0];
            //Console.WriteLine(field.GetValue(student));
            //Console.WriteLine(field.GetValue(student2));

            foreach (FieldInfo field in fields)
            {
                if (field.FieldType.IsAssignableFrom(typeof(Int32)))
                {
                    field.SetValue(student, -50);
                }
                Console.WriteLine(field.Name + ":" + field.GetValue(student));
                Console.WriteLine();
            }
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
