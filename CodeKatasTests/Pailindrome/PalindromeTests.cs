using CodeKatas.Pailindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatasTests.Pailindrome
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeUsingArrayTest()
        {
           Assert.IsTrue(Palindrome.IsPalindromeUsingArray("Deleveled"));
            Assert.IsFalse(Palindrome.IsPalindromeUsingArray("not"));


        }

        [TestMethod()]
        public void IsPalindromeUsingLinqTest()
        {
            Assert.IsTrue(Palindrome.IsPalindromeUsingLinq("Deleveled"));
            Assert.IsFalse(Palindrome.IsPalindromeUsingLinq("not"));
        }
    }
}