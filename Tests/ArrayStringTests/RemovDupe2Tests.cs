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
    public class RemovDupe2Tests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
                int[] nums = nums = [1, 1, 1, 2, 2, 3];
                int expected = 5;
                int[] expectedNums = [1, 1, 2, 2, 3];
                RemovDupe2 tester = new();
                int actual = tester.RemoveDuplicates(nums);
                Assert.AreEqual(expected, actual);
                CollectionAssert.AreEqual(expectedNums, nums[0..expected]);
            }
            [TestMethod()]
            public void RemoveDuplicatesTest2()
            {
                int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];
                int expected = 7;
                int[] expectedNums = [0, 0, 1, 1, 2, 3, 3];
                RemovDupe2 tester = new();
                int actual = tester.RemoveDuplicates(nums);
                Assert.AreEqual(expected, actual);
                CollectionAssert.AreEqual(expectedNums, nums[0..expected]);
            }
        }
}
