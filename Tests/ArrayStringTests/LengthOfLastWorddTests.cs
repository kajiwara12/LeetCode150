using ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString.Tests
{
    [TestClass()]
    public class LengthOfLastWorddTests
    {
        [TestMethod()]
        public void LengthOfLastWordTest()
        {
            LengthOfLastWordd test = new LengthOfLastWordd();
            int result = test.LengthOfLastWord("Hello World");
            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void LengthOfLastWordTest2()
        {
            LengthOfLastWordd test = new LengthOfLastWordd();
            int result = test.LengthOfLastWord("   fly me   to   the moon  ");
            Assert.AreEqual(4, result);
        }
        [TestMethod()]
        public void LengthOfLastWordTest3()
        {
            LengthOfLastWordd test = new LengthOfLastWordd();
            int result = test.LengthOfLastWord("Ace lives on in Sabo and Luffy");
            Assert.AreEqual(5, result);
        }

    }
}