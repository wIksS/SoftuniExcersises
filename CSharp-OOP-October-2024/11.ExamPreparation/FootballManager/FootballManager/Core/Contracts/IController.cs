namespace FootballManager.Core.Contracts
{
    public interface IController
    {
        string JoinChampionship(string teamName);

        string SignManager(string teamName, string managerTypeName, string managerName);

        string MatchBetween(string teamOneName, string teamTwoName);

        string PromoteTeam(string droppingTeamName, string promotingTeamName, string managerTypeName, string managerName);

        string ChampionshipRankings();
    }
}
