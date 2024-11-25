using FootballManager.Core.Contracts;
using FootballManager.Models;
using FootballManager.Models.Contracts;
using FootballManager.Repositories;
using FootballManager.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Core
{
    public class Controller : IController
    {
        private TeamRepository championship;
        private string[] managerTypes = new string[]
        {
            typeof(AmateurManager).Name,
            typeof(ProfessionalManager).Name,
            typeof(SeniorManager).Name
        };

        public Controller()
        {
            this.championship = new TeamRepository();
        }

        public string JoinChampionship(string teamName)
        {
            if (championship.Capacity == championship.Models.Count)
            {
                return OutputMessages.ChampionshipFull;
            }

            if (championship.Exists(teamName))
            {
                return String.Format(OutputMessages.TeamWithSameNameExisting, teamName);
            }

            Team team = new Team(teamName);
            championship.Add(team);

            return String.Format(OutputMessages.TeamSuccessfullyJoined, teamName);

        }

        public string SignManager(string teamName, string managerTypeName, string managerName)
        {
            if (!championship.Exists(teamName))
            {
                return String.Format(OutputMessages.TeamDoesNotTakePart, teamName);
            }

            if (!managerTypes.Contains(managerTypeName))
            {
                return String.Format(OutputMessages.ManagerTypeNotPresented, managerTypeName);
            }

            ITeam team = championship.Get(teamName);

            if (team.TeamManager != null)
            {
                return String.Format(OutputMessages.TeamSignedWithAnotherManager, teamName, team.TeamManager.Name);
            }

            foreach (var currentTeam in championship.Models)
            {
                if (currentTeam.TeamManager?.Name == managerName)
                {
                    return String.Format(OutputMessages.ManagerAssignedToAnotherTeam, managerName);
                }
            }

            IManager manager = CreateManager(managerTypeName, managerName);

            team.SignWith(manager);

            return String.Format(OutputMessages.TeamSuccessfullySignedWithManager, managerName, teamName);
        }

        public string MatchBetween(string teamOneName, string teamTwoName)
        {
            if (!championship.Exists(teamOneName) || !championship.Exists(teamTwoName))
            {
                return String.Format(OutputMessages.OneOfTheTeamDoesNotExist);
            }

            ITeam teamOne = championship.Get(teamOneName);
            ITeam teamTwo = championship.Get(teamTwoName);

            ITeam winningTeam = teamOne;
            ITeam loosingTeam = teamTwo;

            if (teamOne.PresentCondition < teamTwo.PresentCondition)
            {
                winningTeam = teamTwo;
                loosingTeam = teamOne;
            }
            else if (teamOne.PresentCondition == teamTwo.PresentCondition)
            {
                teamOne.GainPoints(1);
                teamTwo.GainPoints(1);

                return String.Format(OutputMessages.MatchIsDraw, teamOneName, teamTwoName);
            }

            winningTeam.GainPoints(3);

            if (winningTeam.TeamManager != null)
            {
                winningTeam.TeamManager.RankingUpdate(5);
            }
            if (loosingTeam.TeamManager != null)
            {
                loosingTeam.TeamManager.RankingUpdate(-5);
            }

            return String.Format(OutputMessages.TeamWinsMatch, winningTeam.Name, loosingTeam.Name);
        }

        public string PromoteTeam(string droppingTeamName, string promotingTeamName, string managerTypeName, string managerName)
        {
            if (!championship.Exists(droppingTeamName))
            {
                return String.Format(OutputMessages.DroppingTeamDoesNotExist, droppingTeamName);
            }

            if (championship.Exists(promotingTeamName))
            {
                return String.Format(OutputMessages.TeamWithSameNameExisting, promotingTeamName);
            }

            ITeam team = new Team(promotingTeamName);

            if (managerTypes.Contains(managerTypeName))
            {
                bool hasManagerSigned = false;
                foreach (var currentTeam in championship.Models)
                {
                    if (currentTeam.TeamManager?.Name == managerName)
                    {
                        hasManagerSigned = true;
                    }
                }

                if (!hasManagerSigned)
                {

                    IManager manager = CreateManager(managerTypeName, managerName);
                    team.SignWith(manager);
                }
            }

            foreach (var currentTeam in championship.Models)
            {
                currentTeam.ResetPoints();
            }

            championship.Remove(droppingTeamName);
            championship.Add(team);

            return String.Format(OutputMessages.TeamHasBeenPromoted, promotingTeamName);
        }

        public string ChampionshipRankings()
        {
            StringBuilder result = new StringBuilder();

            List<ITeam> teams = championship.Models
                .OrderByDescending(t => t.ChampionshipPoints)
                .ThenByDescending(t => t.PresentCondition)
                .ToList();

            result.AppendLine("***Ranking Table***");

            int row = 1;
            foreach (var team in teams)
            {
                result.AppendLine($"{row++}. {team}/{team.TeamManager}");
            }

            return result.ToString().Trim();
        }

        private IManager CreateManager(string managerTypeName, string managerName)
        {
            IManager manager = null;

            if (managerTypeName == typeof(AmateurManager).Name)
            {
                manager = new AmateurManager(managerName);
            }
            if (managerTypeName == typeof(SeniorManager).Name)
            {
                manager = new SeniorManager(managerName);
            }
            if (managerTypeName == typeof(ProfessionalManager).Name)
            {
                manager = new ProfessionalManager(managerName);
            }

            return manager;
        }
    }
}
