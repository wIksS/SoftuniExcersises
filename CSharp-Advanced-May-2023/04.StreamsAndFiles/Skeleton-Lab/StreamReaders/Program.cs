

StreamReader reader = new StreamReader(@"C:\Users\Viktor\Downloads\Skeleton_6.0-Lab\Skeleton-Lab\StreamReaders\input.txt");

string input = reader.ReadToEnd();

Console.WriteLine(input);

reader.Close();

//while (!reader.EndOfStream)
//{
//    string line = reader.ReadLine();

//    Console.WriteLine(line);
//}
