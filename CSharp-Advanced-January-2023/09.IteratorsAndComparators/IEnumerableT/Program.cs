


using System.Collections;

IEnumerable<int> collection = new List<int>();

interface SoftuniIEnumerable<T>
{
    public IEnumerator<T> GetEnumerator();

}