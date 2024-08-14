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
    public class MajorityElementsTests
    {
        [TestMethod()]
        public void MajorityElementTest()
        {
            int[] nums = [3, 2, 3];
            int expected = 3;
            MajorityElements m = new();
            var actual = m.MajorityElement(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MajorityElementTest2()
        {
            int[] nums = [2, 2, 1, 1, 1, 2, 2];
            int expected = 2;
            MajorityElements m = new();
            var actual = m.MajorityElement(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}