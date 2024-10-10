

using System.Collections;
using System.Text;

List<int> list = new List<int> { 1, 2, 3 };
StringBuilder sb = new StringBuilder();
University university = new University();


foreach (var student in university)
{
    Console.WriteLine(student);
}

class University : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        return null;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}