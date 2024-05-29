namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class RailWayStationTests
    {
        private RailwayStation station;
        string train = "sofia-varna";

        [SetUp]
        public void Setup()
        {
            station = new RailwayStation("station");
        }

        [Test]
        public void CheckConstructor_SavesCorrectly()
        {
            Assert.AreEqual("station", station.Name);
            Assert.AreEqual(0, station.ArrivalTrains.Count);
            Assert.AreEqual(0, station.DepartureTrains.Count);
        }

        [Test]
        public void NameNullOrWhiteSpace_Throws()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var newStation = new RailwayStation(null);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var newStation = new RailwayStation(" ");
            });
        }

        [Test]
        public void NewArrival_ShouldAddToArrivalTrains()
        {
            station.NewArrivalOnBoard($"{train}");

            Assert.AreEqual(1, station.ArrivalTrains.Count);
            Assert.AreEqual($"{train}", station.ArrivalTrains.Dequeue());
        }

        [Test]
        public void TrainHasArrived_ShouldWorkCorrectly()
        {
            station.NewArrivalOnBoard($"{train}");

            Assert.AreEqual("There are other trains to arrive before plovdiv-sofia.", station.TrainHasArrived("plovdiv-sofia"));


            Assert.AreEqual($"{train} is on the platform and will leave in 5 minutes.", station.TrainHasArrived($"{train}"));

            Assert.AreEqual(1, station.DepartureTrains.Count);
            Assert.AreEqual($"{train}", station.DepartureTrains.Dequeue());
            Assert.AreEqual(0, station.ArrivalTrains.Count);
        }

        [Test]
        public void TrainHasLeft_ShouldWorkCorrectly()
        {
            station.NewArrivalOnBoard(train);

            station.TrainHasArrived(train);

            Assert.AreEqual(false, station.TrainHasLeft("Non existant"));
            Assert.AreEqual(true, station.TrainHasLeft(train));
            Assert.AreEqual(0, station.DepartureTrains.Count);
        }
    }
}