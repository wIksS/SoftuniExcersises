using System;

namespace InputOuput
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "some string";
            string y = "other string";
            string result = x + y;

            Console.WriteLine("Dvata stringa sa: {1} - {0}", x, y);
            return;
            Console.WriteLine(result);
            Console.WriteLine("Myjaga li si" + "?");
            bool isMale = bool.Parse(Console.ReadLine());
            Console.WriteLine(isMale);

            int day = 15;
            int month = 3;
            Console.WriteLine("Today is: {0:D2}:{1:D2}:2021", day, month);
            Console.WriteLine($"Today is {day:D2}:{month:D2}:2021");

            Console.WriteLine("PI is: {0:F2}", 3.1431231235136);

            Console.WriteLine("{0}  -  {1}  -  {2}", 4, 2, 3);

            Console.WriteLine("Kak se kazvash??");
            string name = Console.ReadLine();

            Console.WriteLine("Zdravei {0}", name);

            Console.WriteLine("Na kolko godini si?");
            double age = double.Parse(Console.ReadLine());

            Console.WriteLine("Sled godini ste si na: {0}", age + 10);

            Console.WriteLine($"Sled 10 shte si na: {age + 10}");
        }
    }
}
