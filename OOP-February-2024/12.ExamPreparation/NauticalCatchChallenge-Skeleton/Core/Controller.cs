using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Core
{
    public class Controller : IController
    {
        private DiverRepository divers;
        private FishRepository fish;
        private string[] diverTypes = new string[] { typeof(ScubaDiver).Name, typeof(FreeDiver).Name };
        private string[] fishTypes = new string[] { typeof(ReefFish).Name, typeof(PredatoryFish).Name, typeof(DeepSeaFish).Name };

        public Controller()
        {
            divers = new DiverRepository();
            fish = new FishRepository();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            if (!diverTypes.Contains(diverType))
            {
                return String.Format(OutputMessages.DiverTypeNotPresented, diverType);
            }

            if (divers.GetModel(diverName) != null)
            {
                return String.Format(OutputMessages.DiverNameDuplication, diverName, typeof(DiverRepository).Name);
            }

            IDiver diver = null; 

            if (diverType == typeof(ScubaDiver).Name)
            {
                diver = new ScubaDiver(diverName);
            }
            if (diverType == typeof(FreeDiver).Name)
            {
                diver = new FreeDiver(diverName);
            }

            divers.AddModel(diver);

            return String.Format(OutputMessages.DiverRegistered, diverName, typeof(DiverRepository).Name);
        }


        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if (!fishTypes.Contains(fishType))
            {
                return String.Format(OutputMessages.FishTypeNotPresented, fishType);
            }

            if (fish.GetModel(fishName) != null)
            {
                return String.Format(OutputMessages.FishNameDuplication, fishName, typeof(FishRepository).Name);
            }

            IFish newFish = null;

            if (fishType == typeof(ReefFish).Name)
            {
                newFish = new ReefFish(fishName, points);
            }
            if (fishType == typeof(DeepSeaFish).Name)
            {
                newFish = new DeepSeaFish(fishName, points);
            }
            if (fishType == typeof(PredatoryFish).Name)
            {
                newFish = new PredatoryFish(fishName, points);
            }

            fish.AddModel(newFish);

            return String.Format(OutputMessages.FishCreated, fishName);
        }

        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            if (divers.GetModel(diverName) == null)
            {
                return String.Format(OutputMessages.DiverNotFound, typeof(DiverRepository).Name, diverName);
            }

            if (fish.GetModel(fishName) == null)
            {
                return String.Format(OutputMessages.FishNotAllowed,fishName);
            }

            IDiver diver = divers.GetModel(diverName);
            IFish currentFish= fish.GetModel(fishName);

            if (diver.HasHealthIssues)
            {
                return String.Format(OutputMessages.DiverHealthCheck, diverName);
            }

            if (diver.OxygenLevel < currentFish.TimeToCatch)
            {
                diver.Miss(currentFish.TimeToCatch);
                return String.Format(OutputMessages.DiverMisses, diverName, fishName);
            }
            else if (diver.OxygenLevel == currentFish.TimeToCatch)
            {
                if (isLucky)
                {
                    diver.Hit(currentFish);
                    return String.Format(OutputMessages.DiverHitsFish, diverName, currentFish.Points, currentFish.Name);
                }
                else
                {
                    diver.Miss(currentFish.TimeToCatch);
                    return String.Format(OutputMessages.DiverMisses, diverName, fishName);
                }
            }
            else
            {
                diver.Hit(currentFish);
                return String.Format(OutputMessages.DiverHitsFish, diverName, currentFish.Points, currentFish.Name);
            }

        }

        public string HealthRecovery()
        {
            List<IDiver> healthIssueDivers = divers.Models.Where(d => d.HasHealthIssues).ToList();

            foreach (var diver in healthIssueDivers)
            {
                diver.UpdateHealthStatus();
                diver.RenewOxy();
            }

            return String.Format(OutputMessages.DiversRecovered, healthIssueDivers.Count);
        }

        public string DiverCatchReport(string diverName)
        {
            IDiver diver = divers.GetModel(diverName);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(diver.ToString());

            sb.AppendLine("Catch Report:");

            foreach (var caughtFish in diver.Catch)
            {
                sb.AppendLine(fish.GetModel(caughtFish).ToString());
            }

            return sb.ToString().Trim();
        }

        public string CompetitionStatistics()
        {
            List<IDiver> diversToReport = divers.Models
                .Where(d => !d.HasHealthIssues)
                .OrderByDescending(d => d.CompetitionPoints)
                .ThenByDescending(d => d.Catch.Count)
                .ThenBy(d => d.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**Nautical-Catch-Challenge**");

            foreach (var diver in diversToReport)
            {
                sb.AppendLine(diver.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
