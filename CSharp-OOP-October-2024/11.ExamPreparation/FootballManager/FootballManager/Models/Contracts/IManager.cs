namespace FootballManager.Models.Contracts
{
    public interface IManager
    {
        public string Name { get; }

        public double Ranking { get; }

        void RankingUpdate(double updateValue);
    }
}
