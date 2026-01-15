//4
//Blue->dress,jeans, hat
//Gold -> dress, t-shirt, boxers
//White -> briefs, tanktop
//Blue -> gloves
//Blue dress

int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> colorItems = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    string[] splittedInput = Console.ReadLine().Split(" -> ");
    string color = splittedInput[0];

    string[] items = splittedInput[1].Split(",");

    if (!colorItems.ContainsKey(color))
    {
        colorItems.Add(color, new Dictionary<string, int>());
    }

    foreach (string item in items)
    {
        if (!colorItems[color].ContainsKey(item))
        {
            colorItems[color].Add(item, 0);
        }

        colorItems[color][item]++;
    }
}

string[] searchItemInput = Console.ReadLine().Split();
string searchColor = searchItemInput[0];
string searchItem = searchItemInput[1];

foreach (var (color, items) in colorItems)
{
    Console.WriteLine($"{color} clothes:");

    foreach (var (item, count) in items)
    {
        string foundText = "";
        if(searchColor == color && searchItem == item)
        {
            foundText = " (found!)";
        }

        Console.WriteLine($"* {item} - {count}{foundText}");
    }
}