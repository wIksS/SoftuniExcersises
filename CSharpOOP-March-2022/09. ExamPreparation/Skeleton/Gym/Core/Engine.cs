namespace Gym.Core
{
    using Gym.Core.Contracts;
    using Gym.IO;
    using Gym.IO.Contracts;
    using System;
    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private IController controller;

        public Engine()
        {
            this.writer = new Writer();
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

                    if (input[0] == "AddGym")
                    {
                        string gymType = input[1];
                        string gymName = input[2];

                        result = controller.AddGym(gymType, gymName);
                    }
                    else if (input[0] == "AddEquipment")
                    {
                        string equipmentType = input[1];

                        result = controller.AddEquipment(equipmentType);
                    }
                    else if (input[0] == "InsertEquipment")
                    {
                        string gymName = input[1];
                        string equipmentType = input[2];

                        result = controller.InsertEquipment(gymName, equipmentType);
                    }
                    else if (input[0] == "AddAthlete")
                    {
                        string gymName = input[1];
                        string athleteType = input[2];
                        string athleteName = input[3];
                        string motivation = input[4];
                        int numberOfMedals = int.Parse(input[5]);

                        result = controller.AddAthlete(gymName, athleteType, athleteName, motivation, numberOfMedals);
                    }
                    else if (input[0] == "TrainAthletes")
                    {
                        string gymName = input[1];

                        result = controller.TrainAthletes(gymName);
                    }
                    else if (input[0] == "EquipmentWeight")
                    {
                        string gymName = input[1];

                        result = controller.EquipmentWeight(gymName);
                    }
                    else if (input[0] == "Report")
                    {
                        result = controller.Report();
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
