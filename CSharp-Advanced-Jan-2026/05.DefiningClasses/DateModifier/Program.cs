namespace DateModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = 
                new DateModifier(Console.ReadLine(), Console.ReadLine());

            Console.WriteLine(dateModifier.CaculateDayDiff());
        }
    }
}
