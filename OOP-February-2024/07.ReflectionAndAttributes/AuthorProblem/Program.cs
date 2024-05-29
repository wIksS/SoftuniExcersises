

namespace AuthorProblem
{
    public class StartUp
    {
        [Author("Dimitrichko")]
        public static void Main()
        {
            new Tracker().PrintMethodsByAuthor();
        }

        [Author("Dimitrichko1")]
        [Author("Dimitrichko2")]
        [Author("Dimitrichko3")]
        public void NewMethod()
        {

        }
    }
}