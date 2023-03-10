
Lion lion = new Lion();

Console.WriteLine(lion.Age);
lion.PrintAge(15);
lion.Sleep();
class Animal
{
    public int Age = 8;

    public void Sleep()
    {
        Console.WriteLine("Sleeping in animal");
    }
}

class Lion : Animal
{
    public int Age = 10;

    public void PrintAge(int Age)
    {
        Console.WriteLine(Age);
        Console.WriteLine(this.Age);
        Console.WriteLine(base.Age);
    }

    public void Sleep()
    {
        base.Sleep();
        Console.WriteLine("Sleeping in Lion");
    }
}