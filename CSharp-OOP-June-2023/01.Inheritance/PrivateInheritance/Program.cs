

class A
{
    private int x = 5;

    public int GetX()
    {
        Console.WriteLine(x);

        return x;
    }
}

class B : A
{
    public void PrintB()
    {
        
        int x = GetX();

        Console.WriteLine(x) ;
    }
}