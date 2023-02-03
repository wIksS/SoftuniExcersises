
Enemy enemy = SpawnEnemies<Enemy>();

T SpawnEnemies<T>() where T : new()
{
    T spawned = new T();

    return spawned;
}

class Enemy
{
    public Enemy()
    {
        Console.WriteLine("In Constructor");
    }
    public string Name { get; set; }    
}