using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Boolean result = BalancedBrackets.HasBalancedBrackets("");
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PartialWrapTrue()
        {
            string input = "Launch[Code]"; ;
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void FullWrapUnbalancedFalse()
        {
            string input = "[LaunchCode"; ;
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void WrongNestedFalse()
        {
            string input = "]["; ;
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, false);
        }
    }
}
