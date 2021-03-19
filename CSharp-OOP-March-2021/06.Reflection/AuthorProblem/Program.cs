using System;
using System.Reflection;

namespace AuthorProblem
{
    [Author("Az")]
    [Author("ti")]
    [Author("nie")]
    public class StartUp
    {
        [Author("Otnovo az")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }

        [Author("Dimitrichko")]
        private static void NextGen()
        {

        }
    }
}
