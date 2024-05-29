

string[] names = { "Pesho", "Dimitrichko", "Goshko", "Niki" };

// name1, name2, name3, ..., nameN

Console.WriteLine(String.Join(", ", names));

for (int i = 0; i < names.Length; i++)
{
    if (i == names.Length - 1)
    {
        Console.Write(names[i]);
    }
    else
    {
        Console.Write(names[i] + ", ");
    }
}
