

interface IStudent
{
    public void Learn();

    public void Forget();
}

class Student : IStudent
{
    public void Learn()
    {
        Console.WriteLine("Learning");
    }

    public void Forget()
    {

    }
}

class Kid : IStudent
{
    public void Learn()
    {
        Console.WriteLine("Playing");
    }

    public void Forget()
    {

    }
}