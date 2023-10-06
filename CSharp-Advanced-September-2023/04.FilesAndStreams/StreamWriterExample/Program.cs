

for (int i = 0; i < 30; i++)
{
    using (StreamWriter writer = new StreamWriter($"../../../[{i}]created.txt", true))
    {
        writer.Write("Nice!without new line!");

        writer.WriteLine("Nice!");
        writer.WriteLine("Nice 3!");
    }
}
