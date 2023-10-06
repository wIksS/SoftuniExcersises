int number = 5;

int another = number;
another = -1;

Console.WriteLine(number);

Student niki = new Student() { Name = "Niki" };

Student gosho = niki;

gosho.Name = "Gosho";

Console.WriteLine(niki);



class Student
{
    public string Name { get; set; }

    public string UserName { get; set; }

    public float Score { get; set; }
}