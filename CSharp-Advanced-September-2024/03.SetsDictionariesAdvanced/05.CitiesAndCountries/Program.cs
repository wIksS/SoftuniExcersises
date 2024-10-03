

Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

int n =int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    //Europe Bulgaria Sofia
    //Europe Bulgaria Plovdiv
    string[] input = Console.ReadLine().Split();
    string continent = input[0];
    string country = input[1];
    string city = input[2];

    if (!continents.ContainsKey(continent))
    {
        continents.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!continents[continent].ContainsKey(country))
    {
        continents[continent].Add(country, new List<string>());
    }

    continents[continent][country].Add(city);
}

//Europe:
//  Bulgaria->Sofia, Plovdiv
//  Poland -> Warsaw, Poznan
//  Germany -> Berlin

foreach (var (continent, countries) in continents)
{
    Console.WriteLine($"{continent}:");

    foreach (var (country, cities) in countries)
    {
        Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
    }
}