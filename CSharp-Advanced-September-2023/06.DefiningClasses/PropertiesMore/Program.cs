Student student = new Student();

student.Name = "somethingduma4something";

Console.WriteLine(student.Name);

class Student
{
    private string[] bannedWords = new string[] { "duma1", "duma2", "duma3" };
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (bannedWords.Contains(value) || bannedWords.Any(b => value.Contains(b)))
            {
                throw new ArgumentException("You cannot use that word as a name!");
            }

            name = value;
        }
    }

    //public string GetName() { return "";}
    //public void SetName(string value) { }
}