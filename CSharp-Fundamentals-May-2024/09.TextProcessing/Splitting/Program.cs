

string text = "Hello!!! How are you? Oh,hey";

string[] words = text.Split(new char[] {
    '.'
    ,','
    ,' '
    ,'!'
    ,'?'
}, StringSplitOptions.RemoveEmptyEntries);

foreach (string word in words)
{
    Console.WriteLine(word);
}