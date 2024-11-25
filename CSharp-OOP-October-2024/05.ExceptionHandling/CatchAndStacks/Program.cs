

using CatchAndStacks;
//try
{
    using (StreamWriter writer = new StreamWriter("../../../test/test/invalid/int.txt"))
    {
        writer.WriteLine("Hello");
    }

}


Console.WriteLine("After that");

//try
//{
//    Reader.Read();
//}
//catch (Exception)
//{

//}
