using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    public static class Student
    {
        public static DateTime StudentHoliday = DateTime.Now;
        
        static Student()
        {
            Console.WriteLine("Yay initialized");
        }
        public static string Name { get; set; }

        public static void AllStudentsParty()
        {
            Console.WriteLine("Today all students are partying");
        }

        public static decimal GetTaxes()
        {
            return 42;
        }

    }
}
