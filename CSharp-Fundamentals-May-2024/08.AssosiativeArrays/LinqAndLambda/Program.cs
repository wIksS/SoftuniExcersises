

List<string> names = new List<string>()
{
    "Goshko",
    "Pesho",
    "Gogi",
    "Gogicha"
};

var filteredNames = names.Where(name => name.Length <= 4).ToList();

var transformedNames = names.Select(ToUpper).ToList();

Console.WriteLine(String.Join(",", transformedNames));

string ToUpper(string name)
{
    return name.ToUpper();
}