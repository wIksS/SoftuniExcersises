using FootballManager.Core.Contracts;
using FootballManager.IO;
using FootballManager.IO.Contracts;

namespace FootballManager.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IController controller;

        public Engine()
        {
            reader = new Reader();
            writer = new Writer();
            controller = new Controller();
        }
        public void Run()
        {
            while (true)
            {
                string[] input = reader.ReadLine().Split();
                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    string result = string.Empty;

                    if (input[0] == "JoinChampionship")
                    {
                        string teamName = input[1];

                        result = controller.JoinChampionship(teamName);
                    }
                    else if (input[0] == "SignManager")
                    {
                        string teamName = input[1];
                        string managerTypeName = input[2];
                        string managerName = input[3];

                        result = controller.SignManager(teamName, managerTypeName, managerName);
                    }
                    else if (input[0] == "MatchBetween")
                    {
                        string teamOneName = input[1];
                        string teamTwoName = input[2];

                        result = controller.MatchBetween(teamOneName, teamTwoName);
                    }
                    else if (input[0] == "PromoteTeam")
                    {
                        string droppingTeamName = input[1];
                        string promotingTeamName = input[2];
                        string managerTypeName = input[3];
                        string managerName = input[4];

                        result = controller.PromoteTeam(droppingTeamName, promotingTeamName, managerTypeName, managerName);
                    }
                    else if (input[0] == "ChampionshipRankings")
                    {
                        result = controller.ChampionshipRankings();
                    }
                    writer.WriteLine(result);
                    writer.WriteText(result);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                    writer.WriteText(ex.Message);
                }
            }
        }
    }
}
