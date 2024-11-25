using FootballManager.Models.Contracts;
using FootballManager.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Repositories
{
    public class TeamRepository : IRepository<ITeam>
    {
        private List<ITeam> models;
        private int capacity = 10;

        public TeamRepository()
        {
            models = new List<ITeam>(); 
        }

        public IReadOnlyCollection<ITeam> Models
        {
            get
            {
                return models.AsReadOnly();
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public void Add(ITeam model)
        {
            if (models.Count >= Capacity)
            {
                return;
            }

            models.Add(model);  
        }

        public bool Exists(string name)
        {
            ITeam model = models.FirstOrDefault(x => x.Name == name);
            if (model == null)
            {
                return false;
            }

            return true;
        }

        public ITeam Get(string name)
        {
            return models.FirstOrDefault(x => x.Name == name); 
        }

        public bool Remove(string name)
        {
            ITeam model = models.FirstOrDefault(x => x.Name == name);
            if (model == null)
            {
                return false;
            }

            return models.Remove(model);
        }
    }
}
