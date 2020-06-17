using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.LongSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            int[] len = new int[nums.Count];
            int[] prev = new int[nums.Count];
            prev[0] = 1;
            for (int i = 1; i < nums.Count; i++)
            {
                int left = i -1;
                if (left > -1)
                {
                    for (int j = left; j >= 0; j--)
                    {
                        if (nums[j] < nums[i])
                        {
                            if (len[left] <= len[j] + 1)
                            {
                                left = j;
                            }
                        }
  
                    }
                }
  
                if (left == -1)
                {
                    len[i] = 1;
                    prev[i] = left;
                }
                else
                {
                    len[i] = 1 + len[left];
                    prev[i] = left;
                }
            }
            int max = 0;
            for (int i = 0; i < len.Length; i++)
            {
                if (len[i] > len[max])
                {
                    max = i;
                }
            }

            while (true)
            {
                Console.WriteLine(len[max]);
                max = prev[max];
            }

            Console.WriteLine(max);
        }
    }
}
