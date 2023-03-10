List<int> list = new List<int>() { 1, 2, 3, 4 };

IReadOnlyCollection<int> readOnly = list.AsReadOnly();

string text = "a";

text += "b";

Console.WriteLine(text);