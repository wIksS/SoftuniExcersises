

PrintNames(1,2,"Pesho", "Gosho", "Dimitrichko", "Pesho", "Gosho", "Dimitrichko", "Pesho", "Gosho", "Dimitrichko");
PrintNames(1,2,"Name");

PrintObjects(1, 2, 3, DateTime.Now, new Object(), new int[10]);

void PrintNames(int x, int y, params string[] names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}

void PrintObjects(params object[] parameters)
{
    int secondParam = (int)parameters[1];
    foreach (var item in parameters)
    {
        Console.WriteLine(item);
    }
}