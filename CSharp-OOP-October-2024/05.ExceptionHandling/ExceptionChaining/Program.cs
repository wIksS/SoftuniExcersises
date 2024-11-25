
try
{
    ReadData();

}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException.Message);
    throw ex;
}


void ReadData()
{
    try
    {
        int.Parse(Console.ReadLine());
    }
    catch (FormatException ex)
    {

        throw new ArgumentException("Input is wrong!", ex);
    }
    catch (OverflowException ex)
    {

        throw new ArgumentException("Input is wrong!", ex);
    }
}