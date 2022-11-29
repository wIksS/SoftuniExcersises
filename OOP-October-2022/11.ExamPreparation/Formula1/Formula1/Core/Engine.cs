namespace Formula1.Core
{
    using System;
    using Formula1.IO;
    using Formula1.IO.Contracts;
    using Formula1.Core.Contracts;
    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private IController controller;

        public Engine()
        {
            this.writer = new FileWriter();
            this.reader = new Reader();
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

                    if (input[0] == "CreatePilot")
                    {
                        string fullName = input[1];

                        result = controller.CreatePilot(fullName);
                    }
                    else if (input[0] == "CreateCar")
                    {
                        string type = input[1];
                        string model = input[2];
                        int horsePower = int.Parse(input[3]);
                        double engineDisplacement = double.Parse(input[4]);

                        result = controller.CreateCar(type, model, horsePower, engineDisplacement);
                    }
                    else if (input[0] == "CreateRace")
                    {
                        string name = input[1];
                        int laps = int.Parse(input[2]);

                        result = controller.CreateRace(name, laps);
                    }
                    else if (input[0] == "AddCarToPilot")
                    {
                        string pilotName = input[1];
                        string carModel = input[2];

                        result = controller.AddCarToPilot(pilotName, carModel);
                    }
                    else if (input[0] == "AddPilotToRace")
                    {
                        string raceName = input[1];
                        string pilotName = input[2];

                        result = controller.AddPilotToRace(raceName, pilotName);
                    }
                    else if (input[0] == "StartRace")
                    {
                        string raceName = input[1];

                        result = controller.StartRace(raceName);
                    }
                    else if (input[0] == "RaceReport")
                    {
                        result = controller.RaceReport();
                    }
                    else if (input[0] == "PilotReport")
                    {
                        result = controller.PilotReport();
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
