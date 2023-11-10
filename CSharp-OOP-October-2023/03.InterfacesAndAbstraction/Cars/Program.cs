

namespace Cars
{
    public class StartUp
    {
        public static void Main()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.Start());

            Console.WriteLine(tesla.Stop());
            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());

        }
    }
}