

class Animal
{
    public virtual void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}
 class Lion : Animal
{
    public sealed override void Sleep()
    {
        Console.WriteLine("Sleeping in lion");
    }
}

class Cub: Lion
{
    public override void Sleep()
    {
        Console.WriteLine("Sleeping in Cub");
    }
}