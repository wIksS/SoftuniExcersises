

using System.Text;

University university = new University();

//university.Students[0] = "Niki";

//university.Students.Clear();
university.Name[0] = '5';

class University
{
    private List<string> students = new List<string>() { "Viktor", "Dimitrichko", "Goshko"};

    public IReadOnlyCollection<string> Students
    {
        get
        {
            return students.AsReadOnly();
        }
    }

    public StringBuilder Name{ get; }
}