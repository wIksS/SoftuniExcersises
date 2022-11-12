using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseLiskov
{
    internal class ScoreboardVisualiser
    {
        private IDatabase database;

        public ScoreboardVisualiser(IDatabase database)
        {
            this.database = database;
        }

        public void ShowScoreboard()
        {
            var scoreboard = database.Load();
            Console.WriteLine(scoreboard.Score);
        }

        public void SaveScoreboard(Scoreboard score)
        {
            database.Save(score);
        }
    }
}
