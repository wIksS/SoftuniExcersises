// See https://aka.ms/new-console-template for more information
using CustomAttributes;

Type type = typeof(Printer);

object[] attrs = type.GetCustomAttributes(typeof(DocumentAttribute), false);
DocumentAttribute attr = (DocumentAttribute)attrs[0];

Console.ForegroundColor = attr.Color;
Console.WriteLine(attr.IsCritical);

[Document]
class Printer
{
    [Document]
    private int field;
    
    [Document]
    public Printer()
    {

    }

    [Document(true, Color = ConsoleColor.Green)]
    public void Print()
    {

    }
}