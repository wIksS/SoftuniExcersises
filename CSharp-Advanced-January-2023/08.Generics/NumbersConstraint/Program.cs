
AcceptNumbersOnly(5);
//AcceptNumbersOnly("5");

void AcceptNumbersOnly<T>(T element) where T : struct,
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
{
    Console.WriteLine(element);
}