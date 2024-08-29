using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString.Tests
{
    [TestClass()]
    public class RedisSampleTests
    {
        [TestMethod()]
        public void AddToSetTest()
        {
            new RedisSample().AddToSet("Quinn", "hElLo W0rLd");
        }

        [TestMethod()]
        public void GetValueFromSetTest()
        {
            string actual = new RedisSample().GetValueFromSet("Quinn");
            string expected = "hElLo W0rLd";
            Assert.AreEqual(expected, actual);
        }
    }
}