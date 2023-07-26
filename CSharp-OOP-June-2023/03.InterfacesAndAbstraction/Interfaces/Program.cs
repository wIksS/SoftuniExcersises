
ICar car = new Car();

car.Break();
car.Accelerate();
car.Start();


interface ICar
{
    void Start()
    {
        Console.WriteLine("Hello from ICar");
    }

    void Break();

    void Accelerate();

    public int Speed { get; set; }
}

class ParentCar
{

}
class Car : ParentCar, ICar
{
    public int Speed { get; set; }


    public void Break()
    {

    }

    public void Accelerate()
    {

    }
}