using System;
using System.IO;

namespace InnerExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            NullReferenceException childNull = new NullReferenceException();
            ArgumentException childArg = new ArgumentException("", childNull);
            Exception baseEx = new Exception("", childArg);

            try
            {
                CalculateSomethingHard();
            }
            catch (Exception ex)
            {
                try
                {
                    LogToFile("", ex.Message);
                }
                catch (Exception)
                {

                    throw new Exception("Could not write to file", ex);
                }
            }

        }

        public static void LogToFile(string path, string message)
        {
            using (StreamWriter wrtier = new StreamWriter(""))
            {

            }
        }

        public static void CalculateSomethingHard()
        {
            // mnogo kod
            throw new OverflowException();
        }
    }
}
