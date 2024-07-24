

List<string> numbersAsStrings = new List<string>()
{
    "5",
    "3",
    "444",
    "2"
};

List<int> numbers = numbersAsStrings.Select(int.Parse).ToList();


Console.WriteLine(String.Join(",",numbers));
int Parse(string n)
{
    return int.Parse(n);
}