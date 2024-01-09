

using Moq;

Mock<ICalculator> mockCalc = new Mock<ICalculator>();

mockCalc.Setup(c => c.Add(It.IsInRange<int>(0, 100, Moq.Range.Inclusive), It.IsAny<int>()))
    .Returns(55);

mockCalc.Setup(c => c.Add(It.IsInRange<int>(101, 1000, Moq.Range.Inclusive), It.IsAny<int>()))
    .Returns(555);

mockCalc.Setup(c => c.Add(5, 6))
    .Returns(300);

mockCalc.Setup(c => c.Minus(It.IsAny<int>(), It.IsAny<int>()))
    .Returns((int a, int b) =>
    {
        Console.WriteLine($"Ïn minus method with params {a} {b}");
        return a - b;
    });

ICalculator calculator = mockCalc.Object;

Console.WriteLine($"Add(5,6) -> {calculator.Add(5, 6)}");
Console.WriteLine($"Add(50,60) -> {calculator.Add(50, 60)}");
Console.WriteLine($"Add(500,6) -> {calculator.Add(500, 6)}");
Console.WriteLine($"Minus(5,6) -> {calculator.Minus(5, 6)}");

class MockCalculator : ICalculator
{
    public int Add(int a, int b)
    {
        if (a == 5 && b == 6)
        {
            return 300;
        }

        if (a > 0 && a <= 100)
        {
            return 55;
        }
        else if (a > 100 && a < 1000)
        {
            return 555;
        }

        return 55;
    }

    public int Minus(int a, int b)
    {
        return 0;
    }
}

public interface ICalculator
{
    int Add(int a, int b);

    int Minus(int a, int b);
}

