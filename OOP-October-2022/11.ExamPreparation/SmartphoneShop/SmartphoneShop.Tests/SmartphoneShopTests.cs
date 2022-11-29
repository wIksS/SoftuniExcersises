using NUnit.Framework;
using System;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        private Smartphone smartPhone;
        private Shop shop;
        private string modelName = "IPhone 13 Pro Max";
        private int maximumCharge = 100;
        private int capacity = 3;
        [SetUp]
        public void SetUp()
        {
            smartPhone = new Smartphone(modelName, maximumCharge);
            shop = new Shop(capacity);

        }

        [Test]
        public void Test_ConstructorIsSettingCorrectly()
        {
            Assert.AreEqual(capacity, shop.Capacity);
            Assert.AreEqual(0, shop.Count);
        }

        [Test]
        public void Test_NegativeCapacityShouldThrow()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                shop = new Shop(-5);
            });
        }

        [Test]
        public void Test_AddSmartphoneShouldWork()
        {
            shop.Add(smartPhone);

            Assert.AreEqual(1, shop.Count);
        }

        [Test]
        public void Test_DublicateSmartphonesShouldNotBeAllowed()
        {
            shop.Add(smartPhone);

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(smartPhone);
            });

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(new Smartphone(modelName, 10000));
            });
        }

        [Test]
        public void Test_PhoneCannotBeAdded_WhenCapacityIsFull()
        {
            shop.Add(new Smartphone("1", 1));
            shop.Add(new Smartphone("2", 1));
            shop.Add(new Smartphone("3", 1));

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(new Smartphone("4", 1));
            });
        }

        [Test]
        public void Test_RemoveSmartphoneShouldWork()
        {
            shop.Add(smartPhone);
            shop.Remove(modelName);

            Assert.AreEqual(0, shop.Count);
        }

        [Test]
        public void Test_RemoveShouldThrow_WhenPhoneIsNotFound()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Remove("Non Existant");
            });
        }

        [Test]
        public void Test_TestPhoneShouldReduceBatteryCharge()
        {
            shop.Add(smartPhone);
            shop.TestPhone(modelName, 50);

            Assert.AreEqual(maximumCharge - 50, smartPhone.CurrentBateryCharge);
        }

        [Test]
        public void Test_TestPhoneShouldThrow_WhenPhoneIsNotFound()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone("Non Existant", 10);
            });
        }

        [Test]
        public void Test_TestPhoneShouldNotWorkOnUnChargedPhones()
        {
            shop.Add(smartPhone);

            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone(modelName, maximumCharge + 1);
            });
        }

        [Test]
        public void Test_ChargePhoneShouldThrow_WhenPhoneIsNotFound()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.ChargePhone("Non Existant");
            });
        }

        [Test]
        public void Test_ChargePhoneShouldSetBatteryToMax()
        {
            shop.Add(smartPhone);

            shop.TestPhone(modelName, 50);

            shop.ChargePhone(modelName);

            Assert.AreEqual(maximumCharge, smartPhone.CurrentBateryCharge);
        }
    }
}