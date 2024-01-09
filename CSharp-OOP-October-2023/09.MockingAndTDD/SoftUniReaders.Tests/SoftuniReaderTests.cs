using Moq;
using NUnit.Framework;
using SoftUniReader;
//using SoftUniReaders.Tests.Fakes;

namespace SoftUniReaders.Tests
{
    public class SoftuniReaderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SoftUniReader_Reads_Correctly()
        {
            Mock<IHTTPRequester> mock = new Mock<IHTTPRequester>();

            mock.Setup(h => h.GetData(It.IsAny<string>()))
                .Returns("Hello");

            SoftuniReader reader = new SoftuniReader(mock.Object);

            string result = reader.ReadSoftUniData();

            Assert.AreEqual(27, result.Length);
        }
    }
}