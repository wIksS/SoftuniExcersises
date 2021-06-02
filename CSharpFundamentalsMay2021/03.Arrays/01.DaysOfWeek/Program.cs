using System;

namespace _01.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] daysOfWeek = 
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday", 
                "Sunday 2"
            };
            // arr length - 3
            // arr[arr.Lenght - 1]
            Console.WriteLine($"The last element is: {daysOfWeek[daysOfWeek.Length - 1]}");

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }
            //Console.WriteLine(daysOfWeek.Length);

            //for (int i = 0; i < daysOfWeek.Length; i++)
            //{
            //    Console.WriteLine($"daysOfWeek[{i}]={daysOfWeek[i]}");
            //}
        }
    }
}
