
Programmer programmer = new Programmer();
programmer.Code();

class Worker
{
    private int salary = 100;
    protected string name;
    public string company;

    private void GetSalary()
    {
        Console.WriteLine("Getting the salary! " + salary);
    }

    public void Work()
    {
        GetSalary();
        Console.WriteLine("Work");
    }
}

class Programmer : Worker
{
    public void Code()
    {
        base.name = "hello";
        base.Work();
    }
}