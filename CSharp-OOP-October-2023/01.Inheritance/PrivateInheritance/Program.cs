
Child child = new Child();

child.PrintChild();

class Parent
{
    private int count = 10;
    protected int age;
    internal int hungry;
    public int publicField;

    public void Print()
    {
        Console.WriteLine(count);
    }
}

class Child : Parent
{
    public void PrintChild()
    {
        Print();
    }
}