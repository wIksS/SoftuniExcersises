Generics<TextReader> reader = new Generics<TextReader>();

reader.Method<StreamReader>();

class Generics<T>
{

    public void Method<T2>()
        where T2 : T
    {

    }
}