Fish fish = new Fish("Nemo");
Shark fish2 = new Shark("Nemo2");

Console.WriteLine(fish2.Name);
class Animal
{
    public Animal(string f, string s, string t)
    {

    }
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine("In name parent constructor");
    }

    public Animal(string name, int age) : this(name)
    {
        Age = age;
        Console.WriteLine("In name age parent constructor");
    }

    public string Name { get; set; }

    public int Age { get; set; }
}


class Fish : Animal
{
    public Fish(string name) : base(name, "hello", "hello")
    {
        Console.WriteLine("In name child constructor");
    }
    public Fish(string name, int age): base(name, age)
    {
        Console.WriteLine("In name age child constructor");
    }
    public int Water { get; set; }
}


class Shark: Fish
{
    public Shark(string name) : base (name)
    {
        Console.WriteLine("In shark constructor");
    }
}