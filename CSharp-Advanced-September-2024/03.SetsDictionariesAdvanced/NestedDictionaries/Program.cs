

Dictionary<string, Dictionary<string, int>> countryCitiesPopulation = new Dictionary<string, Dictionary<string, int>>();


countryCitiesPopulation["Bulgaria"] = new Dictionary<string, int>();

countryCitiesPopulation["Bulgaria"].Add("Sofia",1000000);
countryCitiesPopulation["Bulgaria"].Add("Plovdiv", 1000000);
countryCitiesPopulation["Bulgaria"].Add("Varna", 1000000);
countryCitiesPopulation["Bulgaria"].Add("Burgas", 1000000);

countryCitiesPopulation.Add("UK", new Dictionary<string, int>());

countryCitiesPopulation["UK"].Add("London", 55000000);
countryCitiesPopulation["UK"].Add("Edinburgh", 5000000);


foreach (var (country, cities) in countryCitiesPopulation)
{
    Console.WriteLine($"{country} -> ");
    foreach (var (city,population) in cities)
    {
        Console.WriteLine($"    {city} : {population}, ");
    }

    Console.WriteLine();
}



