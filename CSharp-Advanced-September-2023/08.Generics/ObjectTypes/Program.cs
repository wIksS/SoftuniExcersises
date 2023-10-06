
object everything = new object();
everything = 5;

int number = (int)everything;

everything = "Hello";

List<int> list = (List<int>)everything;


everything = new List<int>();


Print(5);
Print("Hello");
Print(new List<int>());

void Print(object anything)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine(anything);
    Console.BackgroundColor = ConsoleColor.Black;
}

//void Print<T>(T anything)
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//    Console.WriteLine(anything);
//    Console.BackgroundColor = ConsoleColor.Black;
//}


