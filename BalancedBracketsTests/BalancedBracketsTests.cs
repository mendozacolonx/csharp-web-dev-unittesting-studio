using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(true, true);
        //}

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void InvertedOrder()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void Sandwiched()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][]["));
        }

        [TestMethod]
        public void After()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]["));
        }
        [TestMethod]
        public void BeforeAndAfter()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][]["));
        }
        [TestMethod]
        public void FacingOut()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]][["));
        }
        [TestMethod]
        public void ReverseSingleBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void NoPair()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
        }
        [TestMethod]
        public void NoBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("No Brackets Here"));
        }
        [TestMethod]
        public void OnlyOneWithCharacters()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }
        [TestMethod]
        public void InvertedWithCharacters()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
        [TestMethod]
        public void SingleBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
    }
}
