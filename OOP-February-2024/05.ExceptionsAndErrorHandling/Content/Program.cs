
try
{

    int age = int.Parse(Console.ReadLine());

    if (age < 18)
    {
        throw new ArgumentException();
    }
    if (age > 18)
    {
        throw new SystemException();
    }
    if (age > 65)
    {
        throw new ArgumentNullException();
    }
}
catch (ArgumentNullException)
{
    Console.WriteLine("Elderly ad");
}
catch (ArgumentException)
{
    Console.WriteLine("Kids ad");
}
catch (SystemException)
{
    Console.WriteLine("Normal ad");
}