
using System.Text;

Type type = typeof(Robot);

StringBuilder builder = GetInstance<StringBuilder>();
int num = GetInstance<Int32>();


Robot robot = (Robot)Activator.CreateInstance(type);

Console.WriteLine(robot.Name);

T GetInstance<T>()
{
    return (T)Activator.CreateInstance(typeof(T).GetType());   
}

class Robot
{
    public Robot()
    {
        Console.WriteLine("In Constructor");
        Name = "IRobot";
    }

    public string Name { get; set; }
}