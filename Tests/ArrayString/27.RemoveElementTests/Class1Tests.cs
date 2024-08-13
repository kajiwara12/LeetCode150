using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement.Tests
{
    [TestClass()]
    public class Class1Tests
    {
            [TestMethod()]
            public void RemoveElementTest()
            {
                int[] nums = [3, 2, 2, 3];
                int[] expected = [2, 2];
                int val = 3;
                Class1 test = new();
                int k = test.RemoveElement(nums, val);
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
                Class1 test = new();
                int k = test.RemoveElement(nums, val);
                Array.Sort(nums, 0, k);
                Assert.AreEqual(5, k);

                CollectionAssert.AreEqual(nums[0..k], expected);
            }
        }
 }
