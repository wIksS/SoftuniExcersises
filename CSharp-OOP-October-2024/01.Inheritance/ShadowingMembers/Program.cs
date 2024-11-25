
Student student = new Student();

student.SetScore(150);

class Person
{
    public Person()
    {
        Score = 1000;
    }
    public int Score { get; set; }
}

class Student : Person
{
    public Student()
    {
        Score = 100_000;
    }
    public decimal Score { get; set; }


    public void SetScore(int Score)
    {
        Console.WriteLine(Score);
        Console.WriteLine(this.Score);
        Console.WriteLine(base.Score);
    }
}