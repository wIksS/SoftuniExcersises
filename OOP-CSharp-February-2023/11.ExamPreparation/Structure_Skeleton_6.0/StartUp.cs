namespace UniversityCompetition
{
    using UniversityCompetition.Core;
    using UniversityCompetition.Core.Contracts;
    using UniversityCompetition.Models;
    using UniversityCompetition.Repositories;

    public class StartUp
    {
        static void Main()
        {

            //SubjectRepository repo = new SubjectRepository();

            //repo.AddModel(new TechnicalSubject(555, "Test"));
            //repo.AddModel(new TechnicalSubject(555, "Test"));
            //repo.AddModel(new TechnicalSubject(555, "Test"));
            //repo.AddModel(new TechnicalSubject(555, "Test"));
            //repo.AddModel(new TechnicalSubject(555, "Test"));

            //foreach (var item in repo.Models)
            //{
            //    System.Console.WriteLine(item.Id);
            //}
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
