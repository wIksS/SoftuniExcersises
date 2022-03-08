using System;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new SoftuniException() { CourseName = "OOP" };
            }
            catch (SoftuniException e)
            {
                Console.WriteLine(e.GetType());
            }
        }
    }
}
