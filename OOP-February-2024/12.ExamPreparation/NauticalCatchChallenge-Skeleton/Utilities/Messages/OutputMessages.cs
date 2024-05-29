namespace NauticalCatchChallenge.Utilities.Messages
{
    public class OutputMessages
    {
        //Diver
        public const string DiverTypeNotPresented = "{0} is not allowed in our competition.";
        public const string DiverNameDuplication = "{0} is already a participant -> {1}.";
        public const string DiverRegistered = "{0} is successfully registered for the competition -> {1}.";

        //Fish
        public const string FishTypeNotPresented = "{0} is forbidden for chasing in our competition.";
        public const string FishNameDuplication = "{0} is already allowed -> {1}.";
        public const string FishCreated = "{0} is allowed for chasing.";

        //Chasing
        public const string DiverNotFound = "{0} has no {1} registered for the competition.";
        public const string FishNotAllowed = "{0} is not allowed to be caught in this competition.";
        public const string DiverHealthCheck = "{0} will not be allowed to dive, due to health issues.";
        public const string DiverMisses = "{0} missed a good {1}.";
        public const string DiverHitsFish = "{0} hits a {1}pt. {2}.";

        //Recovery
        public const string DiversRecovered = "Divers recovered: {0}";
    }
}
