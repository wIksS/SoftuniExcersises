
using Calculator;
using Moq;

Mock<ICalculator> calculatorMock = new Mock<ICalculator>();

ICalculator calculator = calculatorMock.Object;


calculatorMock.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>()))
    .Returns((int a, int b) =>
    {
        return a + b;
    });
//.Returns(42);

calculatorMock.Setup(c => c.Add(It.IsInRange<int>(0, 100, Moq.Range.Inclusive), It.IsInRange<int>(1, 200, Moq.Range.Inclusive))).Returns(-1);

calculatorMock.Setup(c => c.Add(1, 5)).Returns(6);


Console.WriteLine($"1 + 5 = {calculator.Add(1, 5)}");

Console.WriteLine($"5 + 255 = {calculator.Add(5, 255)}");

calculatorMock.Verify(c => c.Add(1, 5), Times.Once());
