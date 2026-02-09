namespace NewsFeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository (NewsFeed)
            NewsFeed newsfeed = new("TechDaily", 3);

            //Initialize entities (Articles)
            Article article1 = new("AI Revolution", "John Sanders", 1500);
            Article article2 = new("Quantum Leap", "Eaugene Smith", 1200);
            Article article3 = new("Exploring Space", "Mark Lee", 1000);
            Article article4 = new("Future Tech", "Emma Davis", 900);

            //Print Article
            Console.WriteLine(article1);
            //Output: Article: 'AI Revolution' by John Sanders - 1500 words

            //Add articles to the NewsFeed
            newsfeed.AddArticle(article1);
            newsfeed.AddArticle(article2);
            newsfeed.AddArticle(article3);

            //Return Articles Count
            Console.WriteLine(newsfeed.GetArticlesCount());
            //Output: 3

            //Attempt to add article4 - should not be added
            newsfeed.AddArticle(article4);

            //Attemp to add article with existing title - should not be added
            newsfeed.AddArticle(new("AI Revolution", "Steve Smith", 1400));

            //Return Articles Count
            Console.WriteLine(newsfeed.GetArticlesCount());
            //Output: 3

            //Get the shortest article
            Article shortest = newsfeed.GetShortestArticle();
            Console.WriteLine(shortest);
            //Output: Article: 'Exploring Space' by Mark Lee - 1000 words

            //Remove an article
            Console.WriteLine(newsfeed.DeleteArticle("AI Revolution"));
            //Output: True
            Console.WriteLine(newsfeed.DeleteArticle("Future Tech"));
            //Output: False

            //Get deatils of exeisting article
            Console.WriteLine(newsfeed.GetArticleDetails("Quantum Leap"));
            //Output: Article: 'Quantum Leap' by Eaugene Smith - 1200 words

            //Get details for non-existing article
            Console.WriteLine(newsfeed.GetArticleDetails("Future of Food"));
            //Output: Article with title 'Future of Food' not found.

            //Return Articles Count
            Console.WriteLine(newsfeed.GetArticlesCount());
            //Output: 2

            //Try to add article4 again
            newsfeed.AddArticle(article4);

            //Print NewsFeed report
            Console.WriteLine(newsfeed.Report());
            //Output:
            //TechDaily newsfeed content:
            //Emma Davis: Future Tech
            //Mark Lee: Exploring Space
            //Eaugene Smith: Quantum Leap
        }
    }
}
