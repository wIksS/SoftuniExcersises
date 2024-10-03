using System.Text;

GenericClass<int> instance1 = new GenericClass<int>();
GenericClass<string> instance2 = new GenericClass<string>();

instance1.PrintTypeInformation();
instance2.PrintTypeInformation();

//T = Type
class GenericClass<T>
{
    private int field;
    private T genericField;

    public void PrintTypeInformation()
    {
        Console.WriteLine(typeof(T).Name);

        T newGenericVar = default(T);

        Console.WriteLine(newGenericVar);
    }
}


