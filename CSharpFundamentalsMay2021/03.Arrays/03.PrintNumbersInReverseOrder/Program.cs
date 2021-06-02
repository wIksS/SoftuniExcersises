using System;

namespace _03.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //for (int i = 0; i < numbers.Length / 2; i++)
            //{
            //    int temp = numbers[i];
            //    numbers[i] = numbers[numbers.Length - 1 - i];
            //    numbers[numbers.Length - 1 - i] = temp;
            //}

            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
           
            
            
            
            
            
            
            
            
            
            // 1 way
            //int[] reversedNumbers = new int[numbers.Length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
            //}

            //for (int i = 0; i < reversedNumbers.Length; i++)
            //{
            //    Console.Write(reversedNumbers[i] + " ");
            //}
        }
    }
}
