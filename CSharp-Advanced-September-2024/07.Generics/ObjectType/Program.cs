

using System.Text;

Object obj = new object();

obj = 5;

obj = "hello";

obj = new List<int>();

// type safety
ObjectList list = new ObjectList();
//List<int> list = new List<int>();

list.Add(5);
list.Add(6);
list.Add("7");
list.Add(8);

//list.Add("hello");
//list.Add(DateTime.Now);
int sum = 0;
for (int i = 0; i < 4; i++)
{
    sum += (int)list.Get(i);
}

Console.WriteLine(sum);

class ObjectList
{
    private object[] array;
    private int index = 0;

    public ObjectList()
    {
        array = new object[100];
    }

    public void Add(object element)
    {
        array[index++] = element;
    }

    public object Get(int index)
    {
        return this.array[index];
    }

}