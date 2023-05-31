
StreamReader reader1 = new StreamReader("test");

reader1.Close();
reader1.Dispose();

using (StreamReader reader = new StreamReader("test"))
{

}
using (Disposable disposable = new Disposable())
{

}

class Disposable : IDisposable
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}