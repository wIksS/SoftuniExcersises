using System;
using System.Linq;

namespace _3.Rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
     

            for (int i = 0; i < nums.Length; i++)
            {
                //if (nums[i] == 0)
                //{
                //    nums[i] = 0;
                //}
                Console.WriteLine($"{nums[i]} => {(int)Math.Round(nums[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
