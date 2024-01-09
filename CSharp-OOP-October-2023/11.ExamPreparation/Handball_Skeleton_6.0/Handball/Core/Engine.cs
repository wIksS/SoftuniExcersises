namespace Handball.Core
{
    using Handball.Core.Contracts;
    using Handball.IO;
    using Handball.IO.Contracts;
    using System;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IController controller;

        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();
            this.controller = new Controller();
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

                    if (input[0] == "NewTeam")
                    {
                        string name = input[1];

                        result = controller.NewTeam(name);
                    }
                    else if (input[0] == "NewPlayer")
                    {
                        string typeName = input[1];
                        string name = input[2] + " " + input[3];

                        result = controller.NewPlayer(typeName, name);
                    }
                    else if (input[0] == "NewContract")
                    {
                        string playerName = input[1] + " " + input[2];
                        string teamName = input[3];

                        result = controller.NewContract(playerName, teamName);
                    }
                    else if (input[0] == "NewGame")
                    {
                        string firstTeamName = input[1];
                        string secondTeamName = input[2];

                        result = controller.NewGame(firstTeamName, secondTeamName);
                    }
                    else if (input[0] == "PlayerStatistics")
                    {
                        string teamName = input[1];

                        result = controller.PlayerStatistics(teamName);
                    }
                    else if (input[0] == "LeagueStandings")
                    {
                        result = controller.LeagueStandings();
                    }
                    writer.WriteLine(result);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
