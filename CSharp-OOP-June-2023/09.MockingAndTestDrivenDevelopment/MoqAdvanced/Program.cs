

using Moq;
using MoqAdvanced;
using Store.Contracts;

Mock<Store.Store> storeMock = new Mock<Store.Store>(new Mock<IProductDatabase>().Object);

storeMock.Setup(s => s.VisualiseAllProducts())
    .Returns("1 - Test1\r\n2 - Test2\r\n");

Console.WriteLine(storeMock.Object.VisualiseAllProducts());


Mock<ICalculator> calculatorMock = new Mock<ICalculator>();
calculatorMock.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>()))
    .Returns(151)
    .Callback<int, int>((a, b) =>
     {
         Console.WriteLine(a + b);
     })
    .Throws<ArgumentException>();

calculatorMock.Setup(c => c.Add(It.IsInRange<int>(1, 100, Moq.Range.Inclusive), It.IsAny<int>()))
    .Returns(-1);

calculatorMock.Setup(c => c.Add(5, 6))
    .Returns(42);



Console.WriteLine(calculatorMock.Object.Add(55, 6));

Console.WriteLine(calculatorMock.Object.Add(5, 6));
Console.WriteLine(calculatorMock.Object.Add(166, 6));