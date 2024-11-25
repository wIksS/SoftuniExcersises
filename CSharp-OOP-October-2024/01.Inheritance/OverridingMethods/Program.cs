
Programmer programmer = new Programmer();

programmer.Work();

Manager manager = new Manager();

manager.Work();

class Worker
{
    public virtual void Work()
    {
        Console.WriteLine("Working!");
    }
}

class Programmer : Worker
{
    public override void Work()
    {
        base.Work();
        Console.WriteLine("Coding");
    }
}

sealed class Manager : Worker
{
    public override void Work()
    {
        
    }
}

class TeamLead : Manager
{

}