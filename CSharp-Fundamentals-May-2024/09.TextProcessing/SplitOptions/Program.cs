string text = "Hello       How are you Oh hey";

string[] words = text.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

foreach (string word in words)
{
    Console.WriteLine(word);
}