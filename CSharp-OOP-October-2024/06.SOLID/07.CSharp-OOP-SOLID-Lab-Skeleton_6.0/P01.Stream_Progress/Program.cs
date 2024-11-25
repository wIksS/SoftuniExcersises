namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            StreamProgressInfo info = new StreamProgressInfo(new Movie(10,5));

            System.Console.WriteLine(info.CalculateCurrentPercent());
        }
    }
}
