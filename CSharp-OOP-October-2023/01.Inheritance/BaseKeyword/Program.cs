
Programmer programmer = new Programmer();

programmer.Print();

class Employee
{
    public string Name
    {
        get
        {
            Console.WriteLine("You got me!"); return "Pesho Programista";
        }
    }

    public int Age { get; set; }
}

class Programmer : Employee
{
    public string Name
    {
        get
        {
            Console.WriteLine("Ha you can never get me!"); 
            return "Anonymous";
        }
    }
    public void Print()
    {
        Console.WriteLine(this.Name);
        Console.WriteLine(base.Name);
        Console.WriteLine(Name);
    }
}