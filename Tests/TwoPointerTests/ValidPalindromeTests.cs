using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoPointer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointer.Tests
{
    [TestClass()]
    public class ValidPalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            ValidPalindrome test = new ValidPalindrome();
            bool result = test.IsPalindrome("race a car");
            Assert.AreEqual(false,result);
        }
    }
}