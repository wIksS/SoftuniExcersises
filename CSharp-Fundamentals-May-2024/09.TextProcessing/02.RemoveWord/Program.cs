

string word = Console.ReadLine();

string text =  Console.ReadLine();

int index = text.IndexOf(word);

while (index != -1)
{
    text = text.Remove(index, word.Length);
    index = text.IndexOf(word);
}

Console.WriteLine(text);