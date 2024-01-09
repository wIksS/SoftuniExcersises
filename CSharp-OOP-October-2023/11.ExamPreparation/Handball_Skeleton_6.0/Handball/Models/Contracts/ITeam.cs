using System;
using System.Collections.Generic;
using System.Text;

namespace Handball.Models.Contracts
{
    public interface ITeam
    {
        public string Name { get; }
        public int PointsEarned { get; }
        public double OverallRating { get; }
        public IReadOnlyCollection<IPlayer> Players { get; }
        void SignContract(IPlayer player);

        void Win();
        void Lose();
        void Draw();
    }
}
