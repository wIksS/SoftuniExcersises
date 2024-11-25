namespace FootballManager.Utilities.Messages
{
    public class OutputMessages
    {
        //Common
        public const string ManagerTypeNotPresented = "{0} is an invalid manager type for the application.";
        public const string ManagerAssignedToAnotherTeam = "Manager {0} is already assigned to another team.";

        //Join Championship
        public const string TeamWithSameNameExisting = "{0} has already joined the Championship.";
        public const string TeamSuccessfullyJoined = "{0} has successfully joined the Championship.";
        public const string ChampionshipFull = "Championship is full!";

        //Sign Manager
        public const string TeamDoesNotTakePart = "Team {0} does not take part in the Championship.";
        public const string TeamSignedWithAnotherManager = "Team {0} has already signed a contract with {1}.";
        public const string TeamSuccessfullySignedWithManager = "Manager {0} is assigned to team {1}.";

        //Match Between       
        public const string OneOfTheTeamDoesNotExist = "This match does not meet the regulation rules of the Championship.";
        public const string TeamWinsMatch = "Team {0} wins the match against {1}.";
        public const string MatchIsDraw = "The match between {0} and {1} ends in a draw.";

        //Promote Team        
        public const string DroppingTeamDoesNotExist = "Team {0} does not exist in the Championship.";
        public const string TeamHasBeenPromoted = "Team {0} wins a promotion for the new season.";
    }
}
