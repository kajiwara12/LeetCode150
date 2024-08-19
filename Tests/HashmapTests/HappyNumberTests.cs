using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hashmap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashmap.Tests
{
    [TestClass()]
    public class HappyNumberTests
    {
        [TestMethod()]
        public void IsHappyTest()
        {
            HappyNumber test = new();
            int n = 19;
            bool result =test.IsHappy(n);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void IsHappyTest2()
        {
            HappyNumber test = new();
            int n = 2;
            bool result = test.IsHappy(n);
            Assert.IsFalse(result);
        }
    }
}