using System;

namespace MultipleCatches
{
    class Program
    {
        static void Main(string[] args)
        {
            // read an array and return nth element
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Which item do you want");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(arr[index]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ëdno chislo li ne mojesh da vyvedesh???");
                //throw ex;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Edin index ne mojesh");
            }
            catch (Exception ex)
            {
                Console.WriteLine("bazov ex");
            }

        }
    }
}
