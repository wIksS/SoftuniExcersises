
CreateObjects<int>();
CreateObjects<DateTime>();
CreateObjects<string>();

CreateObjects<StreamReader>();


void CreateObjects<T>() where T : new()
{
    T obj = new T();
}


class GenericClass<T>
{

    void GenericMethod<T2>() where T2: T
    {

    }
}   