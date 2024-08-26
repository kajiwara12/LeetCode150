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
    public class RotateArrayTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            int[] output = { 5, 6, 7, 1, 2, 3, 4 };
            RotateArray test = new();
            test.Rotate(array, k);
            CollectionAssert.AreEqual(output, array); 
        }
    }
}