
PrintNames(5, "Pesho", "Gosho", "1", "2",5, DateTime.Now);
PrintNames(6);


void PrintNames(int age, params object[] names)
{
    Console.WriteLine(string.Join(",", names));
}