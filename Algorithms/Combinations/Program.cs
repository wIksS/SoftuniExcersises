using System;
using System.Linq;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 0 };

            GetAllNums(nums,0);
        }

        static void GetAllNums(int[] nums, int index)
        {
            Console.WriteLine(String.Join(",", nums));
            //if (nums.All(n => n == 9))
            //{
            //    return;
            //}

            while ( index < nums.Length &&nums[index] < 9 )
            {
                nums[index]++;
                GetAllNums(nums, index + 1);
            }

        }
    }
}
