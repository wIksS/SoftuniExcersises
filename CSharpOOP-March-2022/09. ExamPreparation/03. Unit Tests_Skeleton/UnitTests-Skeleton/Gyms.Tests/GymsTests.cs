using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    public class GymsTests
    {
        [Test]
        public void Test_Athlete_Creation()
        {
            Athlete athlete = new Athlete("Peshkata");

            Assert.AreEqual("Peshkata", athlete.FullName);
            Assert.AreEqual(false, athlete.IsInjured);
        }

        [Test]
        public void Test_Gym_Creation()
        {
            Gym gym = new Gym("Qki sme", 15);

            Assert.AreEqual("Qki sme", gym.Name);
            Assert.AreEqual(15, gym.Capacity);
            Assert.AreEqual(0, gym.Count);
        }

        [Test]
        public void Test_Gym_Creation_With_Null_Name_Throws()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Gym gym = new Gym(null, 15);
            });
        }

        [Test]
        public void Test_Gym_Creation_With_Empty_String_Name_Throws()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Gym gym = new Gym("", 15);
            });
        }

        [Test]
        public void Test_Gym_Creation_With_Negative_Capcity_Throws()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Gym gym = new Gym("Gym", -1);
            });
        }

        [Test]
        public void Test_Gym_Add_Athlete_Works()
        {
            Gym gym = new Gym("Gym", 3);

            var athlete = new Athlete("Gosho Bavniq");
            var athlete2 = new Athlete("Jorko Bavniq");
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);

            Assert.AreEqual(2, gym.Count);
        }


        [Test]
        public void Test_Gym_Add_Athlete_With_Full_Capacity_Throws()
        {
            Gym gym = new Gym("Gym", 1);

            var athlete = new Athlete("Gosho Bavniq");
            var athlete2 = new Athlete("Jorko Bavniq");
            gym.AddAthlete(athlete);

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.AddAthlete(athlete2);
            });
        }

        [Test]
        public void Test_Gym_Remove_Athlete_Works()
        {
            Gym gym = new Gym("Gym", 3);

            var athlete = new Athlete("Gosho Bavniq");
            var athlete2 = new Athlete("Jorko Bavniq");
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);

            gym.RemoveAthlete(athlete.FullName);

            Assert.AreEqual(1, gym.Count);
        }

        [Test]
        public void Test_Gym_Remove_Athlete_With_Non_Existant_Throws()
        {
            Gym gym = new Gym("Gym", 3);

            var athlete = new Athlete("Gosho Bavniq");
            var athlete2 = new Athlete("Jorko Bavniq");
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.RemoveAthlete("Nqma me!!!!");
            });
        }

        [Test]
        public void Test_Gym_Injure_Athlete_Works()
        {
            Gym gym = new Gym("Gym", 3);

            var athlete = new Athlete("Gosho Bavniq");
            var athlete2 = new Athlete("Jorko Bavniq");
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);

           var returnedAthlete =  gym.InjureAthlete(athlete.FullName);

            Assert.AreEqual(true, athlete.IsInjured);
            Assert.AreSame(athlete, returnedAthlete);
        }

        [Test]
        public void Test_Gym_Injure_Athlete_With_Non_Existant_Throws()
        {
            Gym gym = new Gym("Gym", 3);

            var athlete = new Athlete("Gosho Bavniq");
            var athlete2 = new Athlete("Jorko Bavniq");
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.InjureAthlete("Nqma me!!!!");
            });
        }

        [Test]
        public void Test_Gym_Report_When_Injured_Are_Not_Returned()
        {
            Gym gym = new Gym("Gym", 3);

            var athlete = new Athlete("Gosho Bavniq");
            var athlete2 = new Athlete("Jorko Bavniq");
            gym.AddAthlete(athlete);

            gym.AddAthlete(athlete2);

            var returnedAthlete = gym.InjureAthlete(athlete.FullName);

            var report = gym.Report();

            Assert.AreEqual("Active athletes at Gym: Jorko Bavniq", gym.Report());
        }


        [Test]
        public void Test_Gym_Report_When_All_Healthy_Are_Returned()
        {
            Gym gym = new Gym("Gym", 3);

            var athlete = new Athlete("Gosho Bavniq");
            var athlete2 = new Athlete("Jorko Bavniq");
            gym.AddAthlete(athlete);

            gym.AddAthlete(athlete2);


            var report = gym.Report();

            Assert.AreEqual("Active athletes at Gym: Gosho Bavniq, Jorko Bavniq", gym.Report());
        }


        [Test]
        public void Test_Gym_Report_With_Empty_Gym_Works()
        {
            Gym gym = new Gym("Gym", 3);

            var report = gym.Report();

            Assert.AreEqual("Active athletes at Gym: ", gym.Report());
        }
    }
        
}
