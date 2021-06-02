using System;

namespace _05.MoreExcersises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string state = "beginning";
            bool isBalanced = true;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                if (state == "beginning" && line == ")")
                {
                    isBalanced = false;
                }
                else if (state == "beginning" && line == "(")
                {
                    state = "open";
                }

                else if (state == "open" && line == "(")
                {
                    isBalanced = false;
                }
                else if (state == "open" && line == ")")
                {
                    state = "closed";
                }

                else if (state == "closed" && line == ")")
                {
                    isBalanced = false;
                }
                else if (state == "closed" && line == "(")
                {
                    state = "open";
                }
            }

            if (isBalanced && state == "closed")
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }

}
