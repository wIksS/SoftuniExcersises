namespace Formula1.Utilities
{
    public static class ExceptionMessages
    {
        public const string InvalidF1CarModel = "Invalid car model: {0}.";
        public const string InvalidF1HorsePower = "Invalid car horsepower: {0}.";
        public const string InvalidF1EngineDisplacement = "Invalid car engine displacement: {0}.";
        public const string CarExistErrorMessage = "Formula one car {0} is already created.";
        public const string InvalidTypeCar = "Formula one car type {0} is not valid.";
        public const string CarDoesNotExistErrorMessage = "Car {0} does not exist.";

        public const string InvalidPilot = "Invalid pilot name: {0}.";
        public const string InvalidCarForPilot = "Pilot car can not be null.";
        public const string InvalidPilotForRace = "Null pilot can not be added to a race.";
        public const string PilotExistErrorMessage = "Pilot {0} is already created.";
        public const string PilotDoesNotExistErrorMessage = "Can not add pilot {0} to the race.";
        public const string PilotDoesNotExistOrHasCarErrorMessage = "Pilot {0} does not exist or has a car.";

        public const string InvalidRaceName = "Invalid race name: {0}.";
        public const string InvalidLapNumbers = "Invalid lap numbers: {0}.";
        public const string RaceExistErrorMessage = "Race {0} is already created.";
        public const string RaceDoesNotExistErrorMessage = "Race {0} does not exist.";
        public const string InvalidRaceParticipants = "Race {0} cannot start with less than three participants.";
        public const string RaceTookPlaceErrorMessage = "Can not execute race {0}.";

    }
}
