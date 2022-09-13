namespace Gym
{
    using Gym.Core;
    using Gym.Core.Contracts;
    using Gym.Models.Athletes;
    using Gym.Models.Equipment;
    using Gym.Models.Gyms;
    using Gym.Repositories;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            //EquipmentRepository repo = new EquipmentRepository();
            //repo.Add(new BoxingGloves());
            //System.Console.WriteLine("Find " + repo.FindByType("BoxingGloves"));
            //BoxingGym gym = new BoxingGym("Boxing gym");
            //gym.AddAthlete(new Boxer("Joro dqsnoto", "dokrai", 0));
            //for (int i = 0; i < 10; i++)
            //{
            //    try
            //    {
            //        gym.Exercise();


            //    }
            //    catch (System.Exception)
            //    {
            //        System.Console.WriteLine(gym.Athletes.First().Stamina);
            //        throw;
            //    }
            //}
            //gym.Exercise();
            //gym.AddEquipment(new BoxingGloves());
            //System.Console.WriteLine(gym.GymInfo());

            //return;
            // Don't forget to comment out the commented code lines in the Engine class!
            IEngine engine = new Engine();
            engine.Run();


        }
    }
}
