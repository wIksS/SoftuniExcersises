using System.Collections;

University university = new University();

//collection.GetEnumerator()
// while enumerator.MoveNext() == true
// studentName = enumerator.Current

foreach (string studentName in university)
{
    Console.WriteLine(studentName);
}

ForEach(university);

void ForEach<T>(IEnumerable<T> collection)
{
    IEnumerator<T> enumerator = collection.GetEnumerator();
    while (enumerator.MoveNext())
    {
        Console.WriteLine(enumerator.Current);
    }
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
        //return new UniversityEnumerator(students);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class UniversityEnumerator : IEnumerator<string>
{
    string[] students;
    int index = -1;

    public UniversityEnumerator(string[] students)
    {
        this.students = students;
    }

    public string Current
    {
        get
        {
            return students[index];
        }
    }

    object IEnumerator.Current => this.Current;

    public void Dispose()
    {
        Reset();
    }

    public bool MoveNext()
    {
        return ++index < students.Length;
    }

    public void Reset()
    {
        index = -1;
    }
}
