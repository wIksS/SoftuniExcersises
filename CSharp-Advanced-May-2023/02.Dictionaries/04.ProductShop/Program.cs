Dictionary<string, Dictionary<string, float>> shops = new Dictionary<string, Dictionary<string, float>>();

string command = Console.ReadLine();

while (command != "Revision")
{
    string[] input = command.Split(", ");
    string shop = input[0];
    string product = input[1];
    float price = float.Parse(input[2]);

    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, float>());
    }

    if (!shops[shop].ContainsKey(product))
    {
        shops[shop].Add(product, price);
    }

    shops[shop][product] = price;

    command = Console.ReadLine();
}
//Product: apple, Price: 1.2

shops = shops.OrderBy(x => x.Key)
    .ToDictionary(x=>x.Key, x=>x.Value);

foreach (var (shop, products) in shops)
{
    Console.WriteLine($"{shop}->");

    foreach (var (product, price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}