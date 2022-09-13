namespace Gym.Utilities.Messages
{
    public static class ExceptionMessages
    {
         public const string InvalidAthleteName = "Athlete name cannot be null or empty.";

        public const string InvalidAthleteMotivation = "The motivation cannot be null or empty.";

        public const string InvalidAthleteMedals = "Athlete's number of medals cannot be below 0.";

        public const string InvalidGymName = "Gym name cannot be null or empty.";

        public const string NotEnoughSize = "Not enough space in the gym.";

        public const string InvalidGymType = "Invalid gym type.";

        public const string InvalidEquipmentType = "Invalid equipment type.";

        public const string InexistentEquipment = "There isn’t equipment of type {0}.";

        public const string InvalidAthleteType = "Invalid athlete type.";

        public const string InvalidStamina = "Stamina cannot exceed 100 points.";
    }
}
