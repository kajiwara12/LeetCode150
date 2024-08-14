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
    public class IndexOfFirstOccurenceTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            IndexOfFirstOccurence test = new IndexOfFirstOccurence();
            var result = test.StrStr("sadbutsad", "sad");
            Assert.AreEqual(0, result);
        }
    }
}