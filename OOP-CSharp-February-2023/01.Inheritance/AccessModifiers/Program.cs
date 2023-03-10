
Lion lion = new Lion();

lion.Roar();
lion.Sleep();

class Animal
{
    private int sleepTime = 8;
    protected int protectedField = 2;
    internal int internalField = 3;
    public int publicField = 4;

    public void Sleep()
    {
        Console.WriteLine($"Sleeping {sleepTime} hours");
    }
}

class Lion : Animal
{
    public void Roar()
    {
        //Console.WriteLine(privateField);
        Console.WriteLine(protectedField);
        Console.WriteLine(internalField);
        Console.WriteLine(publicField);
    }
}