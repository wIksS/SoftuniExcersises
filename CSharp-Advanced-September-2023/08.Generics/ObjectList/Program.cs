
ObjectList objectList = new ObjectList();

objectList.Add(5);
objectList.Add("string");

int number = (int)objectList.internalArray[0];

class ObjectList
{
    public object[] internalArray;
    private int index=0;

    public ObjectList()
    {
        internalArray = new object[10];  
    }

    public void Add(object element)
    {
        internalArray[index++] = element;
    }
}