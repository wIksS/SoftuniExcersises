
List<int> list;
Dictionary<string, List<string>> countryCities = new Dictionary<string, List<string>>();


countryCities.Add("Bulgaria", new List<string>());

countryCities["Bulgaria"].Add("Sofia");
countryCities["Bulgaria"].Add("Plovdiv");
countryCities["Bulgaria"].Add("Varna");
countryCities["Bulgaria"].Add("Burgas");

countryCities.Add("USA", new List<string>());
countryCities["USA"].Add("LA");
countryCities["USA"].Add("Boston");
countryCities["USA"].Add("Las Vegas");


foreach (var country in countryCities)
{
    Console.Write($"{country.Key} ->");

    foreach (var city  in country.Value)
    {
        Console.Write($" {city}");
    }

    Console.WriteLine();
}
