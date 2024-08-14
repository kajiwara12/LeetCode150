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
    public class RomanToIntegerTests
    {
        [TestMethod()]
        public void RomanToIntTest()
        {
            string s = "III";
            RomanToInteger r = new();
            int expected = 3;
            int actual = r.RomanToInt(s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RomanToIntTest2()
        {
            string s = "LVIII";
            RomanToInteger r = new();
            int expected = 58;
            int actual = r.RomanToInt(s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RomanToIntTest3()
        {
            string s = "MCMXCIV";
            RomanToInteger r = new();
            int expected = 1994;
            int actual = r.RomanToInt(s);
            Assert.AreEqual(expected, actual);
        }
    }
}