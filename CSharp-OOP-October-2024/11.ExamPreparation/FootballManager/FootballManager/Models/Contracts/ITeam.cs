namespace FootballManager.Models.Contracts
{
    public interface ITeam
    {
        public string Name { get; }
        public int ChampionshipPoints { get; }

        public IManager TeamManager { get; }

        public int PresentCondition { get; }

        void SignWith(IManager manager);

        void GainPoints(int points);

        void ResetPoints();
    }
}
