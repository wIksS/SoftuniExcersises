namespace SmartDevice.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Text;

    public class DeviceTests
    {
        private Device device;
        int photoSize = 100;
        int appSize = 300;
        private int memoryCapacity = 1000;
        private string appName = "flappy bird";

        [SetUp]
        public void Setup()
        {
            device = new Device(memoryCapacity);
        }

        [Test]
        public void Test_Constructors_Saves_Correctly()
        {
            Assert.AreEqual(memoryCapacity, device.MemoryCapacity);
            Assert.AreEqual(memoryCapacity, device.AvailableMemory);
            Assert.AreEqual(0, device.Photos);
            Assert.AreEqual(0, device.Applications.Count);
        }

        [Test]
        public void Test_TakePhoto_WorksCorrectly()
        {
            bool result = device.TakePhoto(photoSize);
            Assert.AreEqual(memoryCapacity, device.MemoryCapacity);
            Assert.AreEqual(memoryCapacity - photoSize, device.AvailableMemory);
            Assert.AreEqual(1, device.Photos);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test_TakePhoto_Doesnt_Save_When_No_Memory()
        {
            bool result = device.TakePhoto(memoryCapacity + photoSize);
            Assert.AreEqual(memoryCapacity, device.MemoryCapacity);
            Assert.AreEqual(memoryCapacity, device.AvailableMemory);
            Assert.AreEqual(0, device.Photos);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void Test_InstallApp_WorksCorrectly()
        {
            string result = device.InstallApp(appName, appSize);

            Assert.AreEqual(memoryCapacity, device.MemoryCapacity);
            Assert.AreEqual(memoryCapacity - appSize, device.AvailableMemory);
            Assert.AreEqual(1, device.Applications.Count);
            Assert.AreEqual(true, device.Applications.Contains(appName));
            Assert.AreEqual($"{appName} is installed successfully. Run application?", result);
        }

        [Test]
        public void Test_InstallApp_Throws_WhenNoMemory()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                device.InstallApp(appName, 5000);
            });
        }

        [Test]
        public void Test_FormatDevice_Works_Correctly()
        {
            device.InstallApp(appName, appSize);
            device.TakePhoto(photoSize);

            device.FormatDevice();

            Assert.AreEqual(memoryCapacity, device.MemoryCapacity);
            Assert.AreEqual(memoryCapacity, device.AvailableMemory);
            Assert.AreEqual(0, device.Photos);
            Assert.AreEqual(0, device.Applications.Count);
        }

        [Test]
        public void Test_GetDeviceStatus_Works_Correctly()
        {
            device.InstallApp(appName, appSize);
            device.InstallApp(appName + "2", appSize + 30);
            device.TakePhoto(photoSize);
            var result = device.GetDeviceStatus();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Memory Capacity: 1000 MB, Available Memory: 270 MB");
            sb.AppendLine("Photos Count: 1");
            sb.AppendLine("Applications Installed: flappy bird, flappy bird2");

            Assert.AreEqual(sb.ToString().Trim(), result);       
        }
    }
}