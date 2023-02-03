
Constrainted<IEnumerable<int>> test = new Constrainted<IEnumerable<int>>();

test.Test<List<int>>();
class Constrainted<T>
{
    public void Test<U>() where U : T
    {

    }
}

class Implementation
{
    public Implementation(int x)
    {

    }
    public Implementation()
    {

    }
}