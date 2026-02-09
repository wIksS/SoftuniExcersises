using System.Text;

namespace NewsFeed
{
    public class NewsFeed
    {
        public NewsFeed(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Articles = new List<Article>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Article> Articles { get; set; }

        public void AddArticle(Article article)
        {
            if (Capacity > Articles.Count && !Articles.Any(a => a.Title == article.Title))
            {
                Articles.Add(article);
            }
        }

        public bool DeleteArticle(string title)
        {
            Article article = Articles.FirstOrDefault(a => a.Title == title);
            return Articles.Remove(article);
        }

        public Article GetShortestArticle()
        {
            return Articles.OrderBy(a => a.WordCount).First();
        }

        public string GetArticleDetails(string title)
        {
            Article article = Articles.FirstOrDefault(a => a.Title == title);

            if (article == null)
            {
                return $"Article with title '{title}' not found.";
            }
            else
            {
                return article.ToString();
            }
        }

        public int GetArticlesCount()
        {
            return Articles.Count;
        }

        public string Report()
        {
            //"{Name} newsfeed content:
            //{ article1.Author}: { article1.Title}
            StringBuilder result = new StringBuilder();
            List<Article> sortedArticles = Articles.OrderBy(a => a.WordCount).ToList();

            result.AppendLine($"{Name} newsfeed content:");

            foreach (Article article in sortedArticles)
            {
                result.AppendLine($"{article.Author}: {article.Title}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
