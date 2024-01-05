using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool isPalindrome = Palindrome.Program.IsPalindrome("");
            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool isPalindrome = Palindrome.Program.IsPalindrome("test");
            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool isPalindrome = Palindrome.Program.IsPalindrome("Laval");
            Assert.IsTrue(isPalindrome);
        }
        
        [TestMethod]
        public void TestMethod4()
        {
            bool isPalindrome = Palindrome.Program.IsPalindrome("LAVAL A ETE A LAVAL");
            Assert.IsTrue(isPalindrome);
        }
    }
}