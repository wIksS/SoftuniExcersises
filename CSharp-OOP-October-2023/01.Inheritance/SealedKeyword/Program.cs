

public class Parent
{
    public virtual void Print()
    {

    }
}

class Child : Parent
{
    public sealed override void Print()
    {
        base.Print();
    }
}

class GrandChild : Child
{
    public  void Print()
    {
        base.Print();
    }
}