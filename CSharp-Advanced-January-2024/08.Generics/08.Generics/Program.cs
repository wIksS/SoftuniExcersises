
//Console.WriteLine(typeof(Int32).Name);
//Console.WriteLine(typeof(DateTime).Name);
//Console.WriteLine(typeof(string).Name);

SayHello<string, int, int ,string>("message");
SayHello<int>("int message");
SayHello<List<List<int>>>("list message");


void SayHello<T, T1, T2, T3>(string message)
{
    Console.Write(typeof(T).Name + " ");
    Console.WriteLine(message);
}