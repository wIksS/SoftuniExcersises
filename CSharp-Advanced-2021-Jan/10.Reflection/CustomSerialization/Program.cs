using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CustomSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Id = 1;
            player.Name = "Gogi";
            player.Age = 16;
            player.Games = new List<int> { 1, 2, 3 };
            player.Score = new Score();
            player.Score.Amount = 50;
            player.Score.IsTheBest = false;
            player.Score.ScoreBoard = new ScoreBoard() { Score = 50 };
            var ourJson = Serializer.ToJson(player, 0);
            Console.WriteLine(ourJson);
            Console.WriteLine();
            string json = JsonConvert.SerializeObject(player, Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}
