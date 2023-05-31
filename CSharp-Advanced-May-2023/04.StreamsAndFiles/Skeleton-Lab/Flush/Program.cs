

using System.Text;

using (FileStream stream = new FileStream("../../../flushed.txt", FileMode.Create))
{
    byte[] buffer = Encoding.ASCII.GetBytes("First Line");
    stream.Write(buffer, 0, buffer.Length);
    stream.Write(buffer, 0, buffer.Length);

    stream.Flush();

    stream.Write(buffer, 0, buffer.Length);
    stream.Write(buffer, 0, buffer.Length);

    stream.Flush();

    stream.Write(buffer, 0, buffer.Length);

}

using (StreamWriter writer = new StreamWriter("../../../streamwriter.txt"))
{
    writer.WriteLine("Test");
    writer.WriteLine("Test");
    writer.Flush();

    writer.WriteLine("Test");

}