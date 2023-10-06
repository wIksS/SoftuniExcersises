

NumbersOnly<DateTime> x;

class NumbersOnly<T> where T : struct,
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
{
    public T Bigger(T first, T second)
    {
        
        if (first.CompareTo(second) > 0)
        {
            return first;
        }
        else
        {
            return second.
        }
    }
}