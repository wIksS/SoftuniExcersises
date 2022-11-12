using System;

namespace InnerExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NullReferenceException nullReferenceException = new NullReferenceException();

            ArgumentException argumentException = new ArgumentException("Neshto stana", nullReferenceException);

            IndexOutOfRangeException indexOutOfRange = new IndexOutOfRangeException("Out of range", argumentException);


            try
            {
                throw indexOutOfRange;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Catch argument");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Catch null");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Catch index");
            }
        }
    }
}
