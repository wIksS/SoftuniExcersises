

using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine();

MatchCollection matches = Regex.Matches(input, @"([\@\#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1");

if (matches.Count > 0)
{
    Console.WriteLine($"{matches.Count} word pairs found!");
}
else
{
    Console.WriteLine("No word pairs found!");
}

List<string> mirrorWords = new List<string>();

foreach (Match match in matches)
{
    string firstWord = match.Groups["firstWord"].Value;
    string secondWord = match.Groups["secondWord"].Value;
    //string reversedSecondWord = new string(secondWord.Reverse().ToArray());
    bool areMirror = new string(secondWord.Reverse().ToArray())==firstWord;

    //if (firstWord.Length == secondWord.Length)
    //{
    //    for (int i = 0; i < firstWord.Length; i++)
    //    {
    //        if (firstWord[i] != secondWord[secondWord.Length - i - 1])
    //        {
    //            areMirror = false;
    //            break;
    //        }
    //    }
    //}
    //else
    //{
    //    areMirror = false;
    //}
    if (areMirror)
    {
        mirrorWords.Add($"{firstWord} <=> {secondWord}");
    }
}

if (mirrorWords.Count > 0)
{
    Console.WriteLine($"The mirror words are:");
    Console.WriteLine(String.Join(", ", mirrorWords));
}
else
{
    Console.WriteLine("No mirror words!");
}