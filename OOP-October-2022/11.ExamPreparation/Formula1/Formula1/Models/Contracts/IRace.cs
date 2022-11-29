namespace Formula1.Models.Contracts
{
    using System.Collections.Generic;
    public interface IRace
    {
        public string RaceName { get; }

        public int NumberOfLaps { get; }

        public bool TookPlace { get; set; }

        ICollection<IPilot> Pilots { get; }

        void AddPilot(IPilot pilot);

        public string RaceInfo();
    }
}
