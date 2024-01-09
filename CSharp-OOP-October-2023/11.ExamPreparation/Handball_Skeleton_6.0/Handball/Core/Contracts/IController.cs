namespace Handball.Core.Contracts
{
    public interface IController
    {
        string NewTeam(string name);
        string NewPlayer(string typeName, string name);
        string NewContract(string playerName, string teamName);
        string NewGame(string firstTeamName, string secondTeamName);
        string PlayerStatistics(string teamName);
        string LeagueStandings();
    }
}
