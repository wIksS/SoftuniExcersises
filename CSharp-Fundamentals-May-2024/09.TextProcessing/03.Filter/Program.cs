
string test = @"tekst
s nov
red";

string[] bannedWords = Console.ReadLine().Split(", ");

string text = Console.ReadLine();

foreach (var bannedWord in bannedWords)
{
    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
}

Console.WriteLine(text);