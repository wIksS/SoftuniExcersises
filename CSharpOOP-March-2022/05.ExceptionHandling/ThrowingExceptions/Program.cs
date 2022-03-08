using System;

namespace ThrowingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;

            try
            {
                int x = 0 / y;

            }
            catch (DivideByZeroException ex)
            {
                throw new ArgumentException("vyrni se v treti klas", ex);
            }
        }

    }
}


