
SoftuniDictionary<string, int> dict= new SoftuniDictionary<string, int>();

dict.Add("Pesho", 6);

class SoftuniDictionary<TKey, TValue>
{
    private List<KeyValuePair<TKey, TValue>> list = new List<KeyValuePair<TKey, TValue>>();
    public void Add(TKey key, TValue value)
    {
        list.Add(new KeyValuePair<TKey, TValue>(key, value));
    }
}