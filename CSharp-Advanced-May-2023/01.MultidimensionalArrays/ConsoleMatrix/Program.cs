int cols = 0;
while (true)
{
    Console.SetCursorPosition(20 + cols, 5);
    Console.WriteLine("H");
    Console.SetCursorPosition(20 + cols, 6);
    Console.WriteLine("e");
    Console.SetCursorPosition(20 + cols, 7);
    Console.WriteLine("l");
    Console.SetCursorPosition(20 + cols, 8);
    Console.WriteLine("l");
    Console.SetCursorPosition(20 + cols, 9);
    Console.WriteLine("o");
    Console.SetCursorPosition(20 + cols, 10);

    Thread.Sleep(150);
    Console.Clear();
    cols++;
}


