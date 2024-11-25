namespace Championship
{
    public class Team
    {
        public Team(string name)
        {
            Name = name;
            Wins = 0;
            Draws = 0;
            Loses = 0;
        }

        public string Name { get; set; } = null!;

        public int Wins { get; set; }

        public int Draws { get; set; }

        public int Loses { get; set; }

        public int Points => Wins * 3 + Draws;

        public void Win()
        {
            Wins++;
        }

        public void Draw()
        {
            Draws++;
        }

        public void Lose()
        {
            Loses++;
        }

        public override string ToString()
        {
            return $"{Name} - {Points} points ({Wins}W {Draws}D {Loses}L)";
        }
    }
}
