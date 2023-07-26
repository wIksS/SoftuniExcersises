
using System.Reflection;

Type type = typeof(Human);

FieldInfo field = type.GetField("name", (BindingFlags)60);

Human human = new Human();
Human human2 = new Human("Goshko");

field.SetValue(human, "Changed with Reflection");

Console.WriteLine(field.GetValue(human));
Console.WriteLine(field.GetValue(human2));


class Human
{
    private string name = "The Human";
    public Human()
    {

    }
    public Human(string name)
    {
        this.name = name;
    }
}