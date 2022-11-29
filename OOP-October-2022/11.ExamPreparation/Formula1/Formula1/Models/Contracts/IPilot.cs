namespace Formula1.Models.Contracts
{
    public interface IPilot
    {
        public string FullName { get; }

        public IFormulaOneCar Car { get; }

        public int NumberOfWins { get;}

        public bool CanRace { get; }

        void AddCar(IFormulaOneCar car);

        void WinRace();
    }
}
