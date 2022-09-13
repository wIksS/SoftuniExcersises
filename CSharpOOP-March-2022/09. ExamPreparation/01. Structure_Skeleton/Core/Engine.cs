using System;
using System.Linq;
using WarCroft.Core.IO.Contracts;

namespace WarCroft.Core
{
    public class Engine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly WarController warController;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.warController = new WarController();
        }

        public void Run()
        {
            string command = this.reader.ReadLine();

            while (command != "END")
            {
                try
                {
                    this.ReadCommand(command);
                }
                catch (ArgumentException e)
                {
                    this.writer.WriteLine("Parameter Error: " + e.Message);
                }
                catch (InvalidOperationException e)
                {
                    this.writer.WriteLine("Invalid Operation: " + e.Message);
                }

                command = this.reader.ReadLine();
            }

            this.writer.WriteLine("Final stats:");
            this.writer.WriteLine(this.warController.GetStats());
        }

        private void ReadCommand(string command)
        {
            var commandArgs = command.Split(' ');
            var commandName = commandArgs[0];
            var args = commandArgs.Skip(1).ToArray();

            var output = string.Empty;
            switch (commandName)
            {
                case "JoinParty":
                    output = this.warController.JoinParty(args);
                    break;
                case "AddItemToPool":
                    output = this.warController.AddItemToPool(args);
                    break;
                case "PickUpItem":
                    output = this.warController.PickUpItem(args);
                    break;
                case "UseItem":
                    output = this.warController.UseItem(args);
                    break;
                case "GetStats":
                    output = this.warController.GetStats();
                    break;
                case "Attack":
                    output = this.warController.Attack(args);
                    break;
                case "Heal":
                    output = this.warController.Heal(args);
                    break;
            }

            if (output != string.Empty)
            {
                this.writer.WriteLine(output);
            }
        }
    }
}
