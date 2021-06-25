using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Author = author;
            Content = content;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                //Article, content, Johnny
                string[] input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];

                articles.Add(new Article(title, content, author));
            }

            string sortCriteria = Console.ReadLine();

            if (sortCriteria == "title")
            {
                articles = articles.OrderBy(a => a.Title).ToList();
            }
            if (sortCriteria == "content")
            {
                articles = articles.OrderBy(a => a.Content).ToList();
            }
            if (sortCriteria == "author")
            {
                articles = articles.OrderBy(a => a.Author).ToList();
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
