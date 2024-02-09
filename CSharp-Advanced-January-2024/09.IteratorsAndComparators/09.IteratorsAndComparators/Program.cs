

using System.Collections;

List<int> list = new List<int>();

foreach (var item in list)
{
    Console.WriteLine(item);
}


University university = new University();

foreach (string student in university)
{

}

class University : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}