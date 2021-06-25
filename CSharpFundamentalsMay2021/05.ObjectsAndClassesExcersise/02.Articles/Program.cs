using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Article fashionDays = new Article("Zodiq ribi", "Ribite sa mnogo podmolni", "Kaka ginka");
            Console.WriteLine(fashionDays.ToString());
            string[] input = Console.ReadLine().Split(", ");

            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split(": ");
                string commandName = splitted[0];
                string commandValue = splitted[1];
                if (commandName == "Edit")
                {
                    article.Content = commandValue;
                }
                if (commandName == "ChangeAuthor")
                {
                    article.Author = commandValue;
                }
                if (commandName == "Rename")
                {
                    article.Title = commandValue;
                }
            }

            Console.WriteLine(article);
        }
    }
}
