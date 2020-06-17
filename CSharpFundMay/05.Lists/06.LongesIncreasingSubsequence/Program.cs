using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.LongesIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            int maxSeq = 1;
            int maxStart = 0;
            int maxEnd = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentSeq = 0;
                int currentSeqEnd = i;
                for (int j = i; j < numbers.Count-1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        currentSeq++;
                        currentSeqEnd = j;
                    }
                }

                if (currentSeq > maxSeq)
                {
                    maxSeq = currentSeq;
                    maxStart = i;
                    maxEnd = currentSeqEnd;
                }
            }

            PrintList(numbers, maxStart, maxEnd);
        }

        static void PrintList(List<int> list,int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
