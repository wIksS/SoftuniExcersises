


using Microsoft.Extensions.DependencyInjection;

ServiceCollection collection = new ServiceCollection();

collection.AddSingleton<IDBConnection, DBConnection>();
collection.AddTransient<DataView, DataView>();

IServiceProvider provider = collection.BuildServiceProvider();

for (int i = 0; i < 10; i++)
{
    DataView view = provider.GetRequiredService<DataView>();
    //IDBConnection dbConnection = provider.GetRequiredService<IDBConnection>();

    //Console.WriteLine(dbConnection.Id);
}


class DataView
{
    public DataView(IDBConnection db)
    {
        Console.WriteLine("Data view created");
        Console.WriteLine(db.Id);
    }
}

interface IDBConnection
{
    public Guid Id { get; set; }
    object GetData();
}

class DBConnection : IDBConnection
{
    public DBConnection()
    {
        Console.WriteLine("DB Connection Created");
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }


    public object GetData()
    {
        return 5;
    }
}