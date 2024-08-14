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
    public class BestTimeToBuyAndSellStockTests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            int[] tester = { 7, 1, 5, 3, 6, 4 };
            BestTimeToBuyAndSellStock test = new();
            int k = test.MaxProfit(tester);
            Assert.AreEqual(5, k);
            
        }
    }
}