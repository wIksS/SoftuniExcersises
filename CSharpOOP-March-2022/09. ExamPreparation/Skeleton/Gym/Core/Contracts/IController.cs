namespace Gym.Core.Contracts
{
    public interface IController
    {
        string AddGym(string gymType, string gymName);

        string AddEquipment(string equipmentType);

        string InsertEquipment(string gymName, string equipmentType);

        string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals);

        string TrainAthletes(string gymName);

        string EquipmentWeight(string gymName);

        string Report();
    }
}
