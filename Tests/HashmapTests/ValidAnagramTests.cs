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
    public class ValidAnagramTests
    {
        [TestMethod()]
        public void IsAnagramTest()
        {
            string s = "anagram";
            string t = "nagaram";
            ValidAnagram test = new();
            bool result = test.IsAnagram(s, t);
            Assert.IsTrue(result);
        }
    }
}