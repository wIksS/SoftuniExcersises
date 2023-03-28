using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class StudentRepository : IRepository<IStudent>
    {
        public StudentRepository()
        {
            models = new List<IStudent>();
        }

        private List<IStudent> models;

        public IReadOnlyCollection<IStudent> Models
        {
            get { return models.AsReadOnly(); }
        }

        public void AddModel(IStudent model)
        {
            Student student = new Student(models.Count + 1,model.FirstName, model.LastName);

            models.Add(student);
        }

        public IStudent FindById(int id)
        {
            return models.FirstOrDefault(m => m.Id == id);
        }

        public IStudent FindByName(string name)
        {
            string[] splitted = name.Split(' ');
            string firstName = splitted[0];
            string lastName = splitted[1];

            return models.FirstOrDefault(m => m.FirstName == firstName && m.LastName == lastName);
        }
    }
}
