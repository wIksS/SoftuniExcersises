
//new Fluent().DoSomething().DoNothing().DoSomething();

Lazy<Fluent> lazyFluent = new Lazy<Fluent>(() =>
{
    return new Fluent();
});


lazyFluent.Value.DoSomething();

class Fluent
{
    public Fluent()
    {
        Console.WriteLine("Constructor called");
    }
    public Fluent DoSomething()
    {
        return this;
    }

    public Fluent DoNothing()
    {
        return this;
    }
}