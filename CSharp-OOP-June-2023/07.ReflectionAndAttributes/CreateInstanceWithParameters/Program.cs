

Robot robot = (Robot)Activator.CreateInstance(typeof(Robot),new object[] {"Az Robotyt",5,6});

Console.WriteLine(robot.Name);


class Robot
{
    public Robot(string name)
    {
        Console.WriteLine("In Constructor");
        Name = name;
    }

    public Robot(string name, int age)
    {
        Console.WriteLine("In Constructor" + age);
        Name = name;
    }

    public string Name { get; set; }
}