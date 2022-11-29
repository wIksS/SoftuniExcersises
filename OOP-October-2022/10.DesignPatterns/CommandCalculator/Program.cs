using System;

namespace CommandCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.Clear();
                calculator.Print();
                char sign = char.Parse(Console.ReadLine());
                if (sign == 'u')
                {
                    calculator.Undo();
                    continue;
                }
                if (sign == 'r')
                {
                    calculator.Redo();
                    continue;
                }
                int operand = int.Parse(Console.ReadLine());

                calculator.Operation(sign,operand);
            }

        }
    }
}
