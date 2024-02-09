


using System.Collections;

University university = new University();

foreach (var student in university)
{
    Console.WriteLine(student);
}

class University : IEnumerable<string>
{
    string[] students = new string[] { "Goshko", "Dimitrichko", "Pesho", "Niki" };

    public IEnumerator<string> GetEnumerator()
    {
        foreach (var item in students)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}