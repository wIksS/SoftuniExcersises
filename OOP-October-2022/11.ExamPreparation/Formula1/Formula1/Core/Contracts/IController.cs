namespace Formula1.Core.Contracts
{
    public interface IController
    {
        string CreatePilot(string fullName);

        string CreateCar(string type, string model, int horsepower, double engineDisplacement);

        string CreateRace(string raceName, int numberOfLaps);

        string AddCarToPilot(string pilotName, string carModel);

        string AddPilotToRace(string raceName, string pilotFullName);

        string StartRace(string raceName);

        string RaceReport();

        string PilotReport();
    }
}
