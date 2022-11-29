using Moq;
using System;

namespace MoqCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mock<ICalculator> mockCalculator = new Mock<ICalculator>();
            ICalculator calc = mockCalculator.Object;
            mockCalculator.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Callback<int, int>((a, b) =>
                 {
                     Console.WriteLine($"Before Add method called with {a}, {b}");
                 })
                .Returns((int a, int b) =>
                {
                    Console.WriteLine($"{a}+{b}={a + b}");
                    return a + b;
                })
                .Callback<int, int>((a, b) =>
                {
                    Console.WriteLine($"After Add method called with {a}, {b}");
                });

            Console.WriteLine(calc.Add(5, 6));
        }
    }

    public interface ICalculator
    {
        int Add(int x, int y);
    }
}
