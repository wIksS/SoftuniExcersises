StringRandomizer randomizer = new StringRandomizer();

randomizer.Input = Console.ReadLine();
randomizer.RandomizeInput();

foreach (var item in randomizer.RandomizedInput)
{
    Console.WriteLine(item);
}

class StringRandomizer
{
    public string Input { get; set; }
    public List<string> RandomizedInput { get; set; }

    public void RandomizeInput()
    {
        RandomizedInput = new List<string>();

        List<string> splitted = Input.Split(" ").ToList();
        int count = splitted.Count;
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(0, splitted.Count);
            RandomizedInput.Add(splitted[index]);

            splitted.RemoveAt(index);
        }
    }
}