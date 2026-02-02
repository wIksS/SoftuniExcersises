namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            throw new IndexOutOfRangeException();
            throw new OutOfMemoryException();
            throw new DivideByZeroException();
            throw new NotImplementedException();
            throw new ArgumentException("This does not work like this");
        }
    }
}
