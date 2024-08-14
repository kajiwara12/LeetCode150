using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString.Tests
{
    public class RemoveElementTests
    {
            [TestMethod()]
            public void RemoveElementTest()
            {
                int[] nums = [3, 2, 2, 3];
                int[] expected = [2, 2];
                int val = 3;
                RemoveElement test = new();
                int k = test.RemoveElements(nums, val);
                Array.Sort(nums, 0, k);
                Assert.AreEqual(2, k);

                CollectionAssert.AreEqual(nums[0..k], expected);
            }
            [TestMethod()]
            public void RemoveElementTest2()
            {
                int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];

                int[] expected = [0, 0, 1, 3, 4];
                int val = 2;
                RemoveElement test = new();
                int k = test.RemoveElements(nums, val);
                Array.Sort(nums, 0, k);
                Assert.AreEqual(5, k);

                CollectionAssert.AreEqual(nums[0..k], expected);
            }
        }
}
