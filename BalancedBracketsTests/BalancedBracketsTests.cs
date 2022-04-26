using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        //* These strings have balanced brackets:
        // *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
        // *
        // * While these do not:
        // *   "[LaunchCode", "Launch]Code[", "[", "]["

        [TestMethod]
        public void BalancedBracket()
        {
            string testStr = "[LaunchCode]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void UnbalancedBracket()
        {
            string testStr = "[LaunchCode";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void ClosedBeforeOpen()
        {
            string testStr = "Launch]Code[";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void NoBrackets()
        {
            string testStr = "LaunchCode";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void EmptyString()
        {
            string testStr = "";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void MixedBrackets()
        {
            string testStr = "[LaunchCode}";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void UnevenDoubleOpen()
        {
            string testStr = "[[LaunchCode";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void UnevenDoubleClose()
        {
            string testStr = "LaunchCode]]";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void DoubleOpenAndDoubleClose()
        {
            string testStr = "[[LaunchCode]]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void SpecialChars()
        {
            string testStr = "~%!";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testStr));
        }

        [TestMethod]
        public void CrazyString()
        {
            string testStr = "{[lkjsdf}][[[]]hi]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testStr));
        }
    }
}
