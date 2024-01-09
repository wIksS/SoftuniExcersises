using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithNUnit
{

    public class TestsRunner
    {
        [Test]
        public void TestFromANormalProject()
        {
            Assert.AreEqual(5, 5);
        }
    }


}
