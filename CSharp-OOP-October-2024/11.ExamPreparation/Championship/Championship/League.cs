namespace Championship
{
    public class League
    {
        public League()
        {
            Teams = new List<Team>();
            Capacity = 10;
        }

        public List<Team> Teams { get; }

        public int Capacity { get; }

        public void AddTeam(Team team)
        {
            if (Teams.Count >= Capacity)
            {
                //throw new InvalidOperationException("League is full.");
            }
            if (Teams.Any(t => t.Name == team.Name))
            {
                //throw new InvalidOperationException("Team already exists.");
            }

            Teams.Add(team);
        }

        public bool RemoveTeam(string teamName)
        {
            var team = Teams.FirstOrDefault(t => t.Name == teamName);
            //if (team == null)
            //{
            //    return false;
            //}
            Teams.Remove(team);
            return true;
        }

        public void PlayMatch(string homeTeamName, string awayTeamName, int homeTeamGoals, int awayTeamGoals)
        {
            var homeTeam = Teams.FirstOrDefault(t => t.Name == homeTeamName);
            var awayTeam = Teams.FirstOrDefault(t => t.Name == awayTeamName);
            if (homeTeam == null || awayTeam == null)
            {
                //throw new InvalidOperationException("One or both teams do not exist.");
            }
            if (homeTeamGoals == awayTeamGoals)
            {
                //homeTeam.Draw();
                awayTeam.Draw();
            }
            else if (homeTeamGoals > awayTeamGoals)
            {
                homeTeam.Win();
                //awayTeam.Lose();
            }
            else
            {
                homeTeam.Lose();
                awayTeam.Win();
            }
        }

        public string GetTeamInfo(string teamName)
        {
            var team = Teams.FirstOrDefault(t => t.Name == teamName);
            if (team == null)
            {
                throw new InvalidOperationException("Team does not exist.");
            }
            return team.ToString() +' ';
        }
    }
}
