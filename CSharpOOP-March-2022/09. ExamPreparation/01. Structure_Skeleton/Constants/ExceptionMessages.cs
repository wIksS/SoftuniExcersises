namespace WarCroft.Constants
{
    public class ExceptionMessages
    {
        //Item
        public const string AffectedCharacterDead = "Must be alive to perform this action!";

        //Bag
        public const string ExceedMaximumBagCapacity = "Bag is full!";

        public const string EmptyBag = "Bag is empty!";

        public const string ItemNotFoundInBag = "No item with name {0} in bag!";

        //Character
        public const string CharacterNameInvalid = "Name cannot be null or whitespace!";

        public const string CharacterAttacksSelf = "Cannot attack self!";

        //WarController

        public const string InvalidCharacterType = "Invalid character type \"{0}\"!";

        public const string InvalidItem = "Invalid item \"{0}\"!";

        public const string CharacterNotInParty = "Character {0} not found!";
        
        public const string ItemPoolEmpty = "No items left in pool!";

        public const string AttackFail = "{0} cannot attack!";

        public const string HealerCannotHeal = "{0} cannot heal!";
    }
}
