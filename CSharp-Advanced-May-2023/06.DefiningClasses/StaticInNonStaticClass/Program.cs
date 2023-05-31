
Printer.StaticPrint();
Console.WriteLine(Printer.Color);


Printer printer = new Printer();

printer.Name = "Pesho";


Console.WriteLine(Printer.minAge);
class Printer
{
    public const int minAge = 5;

    // instance member
    public string Name { get; set; }

    // static member
    public static ConsoleColor Color { get; set; }

    public static void StaticPrint()
    {
        Console.WriteLine(Color);
        Console.WriteLine("Printing");
    }

    public void InstancePrint()
    {
        Console.WriteLine(this.Name);
        Console.WriteLine(Color);
        Console.WriteLine("Printing");
    }
}