namespace Handball.Models.Contracts
{
    public interface IPlayer
    {
        public string Name { get; }
        public double Rating { get; }
        public string Team { get; }


        void JoinTeam(string name);

        void IncreaseRating();

        void DecreaseRating();
    }
}
