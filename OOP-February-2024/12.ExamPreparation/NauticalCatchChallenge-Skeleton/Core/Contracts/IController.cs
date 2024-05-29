namespace NauticalCatchChallenge.Core.Contracts
{
    public interface IController
    {
        string DiveIntoCompetition(string diverType, string diverName);
        string SwimIntoCompetition(string fishType, string fishName, double points);
        string ChaseFish(string diverName, string fishName, bool isLucky);
        string HealthRecovery();
        string DiverCatchReport(string diverName);
        string CompetitionStatistics();
    }
}
