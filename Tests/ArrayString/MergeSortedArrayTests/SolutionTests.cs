using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode150.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MergeTest()
        {
            MergeSortedArray m = new MergeSortedArray();
            int[] a = new int[] { 1, 2, 3,0,0,0 };
            int[] b = new int[] { 2, 5, 6 };
            int[] result = new int[] {1,2,2,3,5,6};
            //int[]test = m.Merge(a, 3, b, 3)
            //CollectionAssert.AreEqual(result,);

        }
    }
}