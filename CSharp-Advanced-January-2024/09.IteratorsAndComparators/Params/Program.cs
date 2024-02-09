
PrintNames(2,new string[] { "test", "test2" });
PrintNames<object>(4,"Name1", "Name2",5,DateTime.Now, "Name3");
PrintNames<int>(5,4,3,2,1);

void PrintNames<T>(int n, params T[] names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}