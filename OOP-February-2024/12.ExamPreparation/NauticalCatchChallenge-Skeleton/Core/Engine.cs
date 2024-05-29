namespace NauticalCatchChallenge.Core
{
    using NauticalCatchChallenge.Core.Contracts;
    using NauticalCatchChallenge.IO.Contracts;
    using NauticalCatchChallenge.IO;
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

                    if (input[0] == "DiveIntoCompetition")
                    {
                        string diverType = input[1];
                        string diverName = input[2];

                        result = controller.DiveIntoCompetition(diverType, diverName);
                    }
                    else if (input[0] == "SwimIntoCompetition")
                    {
                        string fishType = input[1];
                        string fishName = input[2];
                        double points = double.Parse(input[3]);

                        result = controller.SwimIntoCompetition(fishType, fishName, points);
                    }
                    else if (input[0] == "ChaseFish")
                    {
                        string diverName = input[1];
                        string fishName = input[2];
                        bool isLusky = bool.Parse(input[3]);

                        result = controller.ChaseFish(diverName, fishName, isLusky);
                    }
                    else if (input[0] == "HealthRecovery")
                    {
                        result = controller.HealthRecovery();
                    }
                    else if (input[0] == "DiverCatchReport")
                    {
                        string diverName = input[1];

                        result = controller.DiverCatchReport(diverName);
                    }
                    else if (input[0] == "CompetitionStatistics")
                    {
                        result = controller.CompetitionStatistics();
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
