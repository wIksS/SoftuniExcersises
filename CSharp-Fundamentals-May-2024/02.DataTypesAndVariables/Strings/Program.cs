

string text = "Hello World!";
string text2 = text + "again";
Console.WriteLine(text2);

for (int i = 0; i < text2.Length; i++)
{
    char symbol = text2[i];

    Console.WriteLine($"{symbol} -> {(int)symbol}");
}