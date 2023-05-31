
for (int i = 0; i < 20; i++)
{
    using (StreamWriter writer = new StreamWriter($"../../../output{i+1}.txt", true))
    {
        writer.Write("Same row");
        writer.WriteLine($"{i + 1}.First write to file success!");
        writer.WriteLine($"New row");
    }
}
