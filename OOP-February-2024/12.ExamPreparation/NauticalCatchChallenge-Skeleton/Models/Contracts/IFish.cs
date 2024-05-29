namespace NauticalCatchChallenge.Models.Contracts
{
    public interface IFish
    {
        string Name { get; }
        double Points { get; }
        int TimeToCatch { get; }
    }
}
