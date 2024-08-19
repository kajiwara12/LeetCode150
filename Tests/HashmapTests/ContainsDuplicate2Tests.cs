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
    public class ContainsDuplicate2Tests
    {
        [TestMethod()]
        public void ContainsNearbyDuplicateTest()
        {
            ContainsDuplicate2 test = new();
            int[] nums = new int[] { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            bool result = test.ContainsNearbyDuplicate(nums, k);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void ContainsNearbyDuplicateTest2()
        {
            ContainsDuplicate2 test = new();
            int[] nums = new int[] { 1, 2, 3, 1 };
            int k = 3;
            bool result = test.ContainsNearbyDuplicate(nums, k);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ContainsNearbyDuplicateTest3()
        {
            ContainsDuplicate2 test = new();
            int[] nums = new int[] { 1, 0, 1, 1 };
            int k = 1;
            bool result = test.ContainsNearbyDuplicate(nums, k);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ContainsNearbyDuplicate2Test()
        {
            ContainsDuplicate2 test = new();
            int[] nums = new int[] { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            bool result = test.ContainsNearbyDuplicate2(nums, k);
            Assert.IsFalse(result);
        }
    }
}