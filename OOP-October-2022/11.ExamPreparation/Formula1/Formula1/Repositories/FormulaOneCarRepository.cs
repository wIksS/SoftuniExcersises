using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Repositories
{
    public class FormulaOneCarRepository : IRepository<IFormulaOneCar>
    {
        public FormulaOneCarRepository()
        {
            models = new List<IFormulaOneCar>();
        }
        private List<IFormulaOneCar> models;
        public IReadOnlyCollection<IFormulaOneCar> Models => this.models.AsReadOnly();

        public void Add(IFormulaOneCar car)
        {
            models.Add(car);
        }

        public IFormulaOneCar FindByName(string model)
        {
            return models.FirstOrDefault(c => c.Model == model);
        }

        public bool Remove(IFormulaOneCar car)
        {
            return models.Remove(car);
        }
    }
}
