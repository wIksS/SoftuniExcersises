

using Moq;

Mock<IMath> mockMath = new Mock<IMath>();

mockMath
    .Setup(m => m.Add(It.IsAny<int>(), It.IsAny<int>()))
    .Returns(10000);

mockMath
    .Setup(m => m.Add(5, 6))
    .Returns(11);


mockMath
    .Setup(m => m.Add(3, It.IsAny<int>()))
    .Returns((int a, int b) =>
    {
        global::System.Console.WriteLine("Multiplying!");
        return a * b;
    })
    .Callback((int a, int b) =>
    {
        global::System.Console.WriteLine($"Mock Math called with:{a} and {b}");
    });


mockMath
    .Setup(m => m.Add(3, It.IsInRange<int>(0,10, Moq.Range.Inclusive)))
    .Returns(-1);


mockMath
    .Setup(m => m.Add(-1, -1))
    .Throws<ArgumentException>(() =>
    {
        throw new ArgumentException("No math with -1!!!!");
    });

IMath math = mockMath.Object;

Console.WriteLine(math.Add(5,6));
Console.WriteLine(math.Add(5, 7));
Console.WriteLine(math.Add(3,9));
Console.WriteLine(math.Add(3, 11));
//Console.WriteLine(math.Add(-1,-1));

mockMath.Verify(m => m.Add(It.IsAny<int>(), It.IsAny<int>()));
mockMath.Verify(m => m.Add(3,9), Times.Exactly(2));

public interface IMath
{
    int Add(int a, int b);
}