namespace Formula1.Models.Contracts
{
    public interface IFormulaOneCar
    {
        public string Model { get; }

        public int Horsepower { get; }

        public double EngineDisplacement { get; }

        double RaceScoreCalculator(int laps);
    }
}
