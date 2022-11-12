using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Before null exception");
                string input = null;
                //input.ToLower();

                Console.WriteLine("Before argument exception");

               // throw new ArgumentException("Zashto?");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine("Before DivideByZero exception");

                Console.WriteLine($"{x}/{y}={x / y}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Always here!!");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Learn maths");          
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine($"Value was null. {e.StackTrace}");
            }
            catch (Exception)
            {
                Console.WriteLine("Handling everything");
            }


            Console.WriteLine("After try-catch block!");
        }
    }
}
