


using Mocks;
using Moq;

Mock<IProductDatabase> dbMock = new Mock<IProductDatabase>();

Store store = new Store(dbMock.Object);
//Store store = new Store(new FakeDb());

IProductDatabase db = dbMock.Object;
db.Save();
db.Delete("");
db.Add("test");
var res = db.GetAll();
Console.WriteLine(res);

class Store
{
    public Store(IProductDatabase db)
    {
        Console.WriteLine(db);
    }
}


class FakeDb : IProductDatabase
{
    public void Add(string product)
    {
    }

    public bool Delete(string product)
    {
        return false;
    }

    public IEnumerable<string> GetAll()
    {
        return null;
    }

    public void Save()
    {
    }
}
