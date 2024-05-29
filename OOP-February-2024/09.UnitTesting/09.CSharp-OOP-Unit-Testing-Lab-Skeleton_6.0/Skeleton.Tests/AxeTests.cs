using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            axe = new Axe(3, 2);
            dummy = new Dummy(5, 2);
        }

        [Test]
        public void NewAxe_ShouldSetDataCorrectly()
        {
            Assert.AreEqual(axe.AttackPoints, 3);
            Assert.AreEqual(axe.DurabilityPoints, 2);
        }

        [Test]
        public void Attack_ShouldDecreaseDurability()
        {
            axe.Attack(dummy);

            Assert.AreEqual(axe.DurabilityPoints, 1);
        }

        [Test]
        public void Attack_WithBrokenWeapon_ShouldThrowError()
        {
            axe.Attack(dummy);
            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }

        [Test]
        public void Attack_WithNegativeDurability_ShouldThrowError()
        {
            axe = new Axe(5, -50);

            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }

        [Test]
        public void Attack_ShouldCall_TakeAttackOnTarget()
        {
            axe.Attack(dummy);

            Assert.AreEqual(dummy.Health, 2);
        }
    }

}