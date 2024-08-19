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
    public class TwoSumsTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            TwoSums test = new();
            int[] nums= { 2, 7, 11, 15 };
            int target = 9;
            int[] result = {0,1};
            int[] values = test.TwoSum(nums, target);
            CollectionAssert.AreEqual(values, result);
        }
    }
}