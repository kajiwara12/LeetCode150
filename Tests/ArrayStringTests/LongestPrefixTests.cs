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
    public class LongestPrefixTests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            string[] str = ["flower", "flow", "flight"];
            LongestPrefix test = new LongestPrefix();
            string result = test.LongestCommonPrefix(str);
            Assert.AreEqual("fl",result);
        }
        [TestMethod()]
        public void LongestCommonPrefixTest2()
        {
            string[] str = ["dog", "racecar", "car"];
            LongestPrefix test = new LongestPrefix();
            string result = test.LongestCommonPrefix(str);
            Assert.AreEqual("", result);
        }
        [TestMethod()]
        public void LongestCommonPrefixTest3()
        {
            string[] str = ["dog", "dog", "dog"];
            LongestPrefix test = new LongestPrefix();
            string result = test.LongestCommonPrefix(str);
            Assert.AreEqual("dog", result);
        }
    }
}