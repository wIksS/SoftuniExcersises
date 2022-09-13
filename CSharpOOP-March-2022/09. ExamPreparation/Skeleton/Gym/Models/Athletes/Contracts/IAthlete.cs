namespace Gym.Models.Athletes.Contracts
{
    public interface IAthlete
    {
        string FullName { get; }
        string Motivation { get; }
        int Stamina { get; }
        int NumberOfMedals { get; }
        void Exercise();
    }
}
