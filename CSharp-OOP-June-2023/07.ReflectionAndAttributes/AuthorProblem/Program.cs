
namespace AuthorProblem
{
    [Author("Victor")][Author("Niki")]
    public class StartUp
    {
        [Author("George")]
        static void Main(string[] args)
        {
            new Tracker().PrintMethodsByAuthor();
        }

        [Author("Dimitrichko")]
        [Author("Goshko")]
        [Author("Toshko")]
        void BestMethod()
        {

        }
    }

}