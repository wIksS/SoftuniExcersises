
using System.Text;

string result;

//using (FileStream fileStream = new FileStream("../../../simple.txt", FileMode.OpenOrCreate))
//{
//    byte[] buffer = new byte[2];

//    fileStream.Read(buffer, 0, buffer.Length);

//    Console.Write((char)buffer[0]);
//    Console.Write((char)buffer[1]);

//    fileStream.Read(buffer, 0, buffer.Length);

//    Console.Write((char)buffer[0]);
//    Console.Write((char)buffer[1]);

//    fileStream.Read(buffer, 0, buffer.Length);

//    Console.Write((char)buffer[0]);
//    Console.Write((char)buffer[1]);
//}


//using (FileStream fileStream = new FileStream("../../../bigTextDocument.txt", FileMode.OpenOrCreate))
//{
//    Console.WriteLine(fileStream.Length/1000/1000/1000.0 +"gb" );
//    byte[] buffer = new byte[8000];

//    while (fileStream.Read(buffer, 0, buffer.Length) > 0)
//    {
//        string chunk = Encoding.ASCII.GetString(buffer);
//        Console.Write(chunk);
//        Thread.Sleep(100);
//    }
//}


using (FileStream fileStream = new FileStream("../../../newFile.txt", FileMode.OpenOrCreate))
{
    string text = "Let's write this down";
    byte[] buffer= Encoding.Unicode.GetBytes(text);
    fileStream.Write(buffer, 0, buffer.Length);
}