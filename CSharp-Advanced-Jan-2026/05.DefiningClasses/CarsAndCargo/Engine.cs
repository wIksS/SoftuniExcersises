namespace CarsAndCargo
{
    public class Engine
    {
        public Engine(double speed, double power)
        {
            Speed = speed;
            Power = power;
        }

        public double Speed { get; set; }

        public double Power { get; set; }
    }
}