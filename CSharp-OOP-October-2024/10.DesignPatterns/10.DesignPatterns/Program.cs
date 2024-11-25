
Lazy<DB> db = new Lazy<DB>();

Console.WriteLine("db is not initialized");

db.Value.GetData();


class DB
{
    public DB()
    {
        Console.WriteLine("DB Connection created");
    }

    public void GetData()
    {
        Console.WriteLine("Printing data");
    }
}