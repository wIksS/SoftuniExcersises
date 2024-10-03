
using (StreamWriter writer = new StreamWriter("../../../output.txt", true))
{
    for (int i = 0; i < 1000; i++)
    {
        writer.WriteLine("Hello");
        if (i == 500)
        {
            writer.Flush();
        }
    }
}
