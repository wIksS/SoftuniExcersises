using System;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BaseCar seat = new Seat("Leon", "Grey");
            BaseCar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
