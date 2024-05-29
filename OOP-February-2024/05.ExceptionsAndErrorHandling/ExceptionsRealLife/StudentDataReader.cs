using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsRealLife
{
    internal class StudentDataReader
    {

        public Student ReadStudent()
        {
            Student student = new Student();
            while (true)
            {
                Console.WriteLine("What is your age");
                int age = int.Parse(Console.ReadLine());
                try
                {
                    student.Age = age;

                    return student;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Try again!");
                }
            }
        }
    }
}
