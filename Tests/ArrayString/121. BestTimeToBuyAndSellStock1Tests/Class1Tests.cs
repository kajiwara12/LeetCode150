using Microsoft.VisualStudio.TestTools.UnitTesting;
using _121._BestTimeToBuyAndSellStock1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121._BestTimeToBuyAndSellStock1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            int[] tester = { 7, 1, 5, 3, 6, 4 };
            Class1 test = new();
            int k = test.MaxProfit(tester);
            Assert.AreEqual(5, k);
        }
    }
}