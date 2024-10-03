
Queue<int> queue;
Dictionary<string, int> dict;
MultipleGenericTypes<string, int> customDict = new MultipleGenericTypes<string, int>();

customDict.Add(5, "key");

class MultipleGenericTypes<TKey, TValue>
{
    private TKey key;
    private TValue value;

    public void Add(TValue value, TKey key)
    {

    }
}