StreamReader reader = null;
try
{

    reader = new StreamReader("../../../Program.cs");

    StreamReader reader2 = new StreamReader("../../../Progr34333am.cs");


    Console.WriteLine("Closing reader!");
    reader.Close();
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("File not found stopping!");
    throw ex;
}
finally
{
    reader.Close();
    Console.WriteLine("This is always executed and reader is closed");
}

Console.WriteLine("After try catch");

using (StreamReader stream2 = new StreamReader(""))
{

}

StreamReader stream = new StreamReader("");
try
{
    stream.ReadToEnd();
}
finally
{
    stream.Dispose();
}