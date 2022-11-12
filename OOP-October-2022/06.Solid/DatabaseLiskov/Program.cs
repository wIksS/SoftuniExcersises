using System;

namespace DatabaseLiskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoreboardVisualiser board = new ScoreboardVisualiser(new Database());
        }
    }
}
