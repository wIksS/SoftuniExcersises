using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;

        public Catalog(string name, int neededRenovators, string project)
        {
            renovators = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int neededRenovators;

        public int NeededRenovators
        {
            get { return neededRenovators; }
            set { neededRenovators = value; }
        }

        private string project;

        public string Project
        {
            get { return project; }
            set { project = value; }
        }

        public int Count { get { return renovators.Count; } }

        public string AddRenovator(Renovator renovator)
        {
            if (String.IsNullOrEmpty(renovator.Name) || String.IsNullOrEmpty(renovator.Type))
            {
                return $"Invalid renovator's information.";
            }
            if (NeededRenovators <= renovators.Count)
            {
                return $"Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            renovators.Add(renovator);

            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(x => x.Name == name);

            return renovators.Remove(renovator);
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            List<Renovator> leftRenovators = renovators.Where(r => r.Type != type).ToList();

            int removedCount = Count - leftRenovators.Count;

            renovators = leftRenovators;

            return removedCount;
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(r => r.Name == name);

            if (renovator != null)
            {
                renovator.Hired = true;
            }

            return renovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            return renovators.Where(r => r.Days >= days).ToList();
        }

        public string Report()
        {
            //            "Renovators available for Project {project}:
            //{ Renovator1}
            //            { Renovator2}
            //            {…}
            //            "
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Renovators available for Project {project}:");
            List<Renovator> unhiredRenovators = renovators.Where(r => r.Hired == false).ToList();

            foreach (var unhired in unhiredRenovators)
            {
                result.AppendLine(unhired.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
