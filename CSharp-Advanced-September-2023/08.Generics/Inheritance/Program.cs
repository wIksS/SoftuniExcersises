
object human = new Human();
human = new Student();


class Human : Object
{
    public string Name { get; set; }
}

class Student : Human
{
    public int Score { get; set; }
}