using Moq;
using System;

namespace MoqExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Mock<ICalculator> mockCalculator = new Mock<ICalculator>();

            mockCalculator.Setup(
                c => c.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(155);

            mockCalculator.Setup(c => c.Add(5, 6))
                .Returns(11);

            mockCalculator.Setup(c => c.Add(-1,-1))
              .Throws(new ArgumentException());

            mockCalculator.Setup(c => c.ToString())
                .Returns("Mocked tostring are the best tostrings");

            Console.WriteLine(mockCalculator.Object.Add(5, 6));
            Console.WriteLine(mockCalculator.Object.Add(5, 7));
            Console.WriteLine(mockCalculator.Object.Add(9, 9));

            mockCalculator.Verify(c => c.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(3));

            mockCalculator.Verify(c => c.Add(8, 9), Times.Once);

            Console.WriteLine(mockCalculator.Object);
        }
    }

    public interface ICalculator
    {
        int Add(int x, int y);
    }
}
