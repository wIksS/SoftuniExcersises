
AddNumbers(5, 5);

AddNumbers(6.0, 5.0f);
AddNumbers("test", 5.0f);


void AddNumbers<T>(T a, T b) where T : struct,
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
{
}