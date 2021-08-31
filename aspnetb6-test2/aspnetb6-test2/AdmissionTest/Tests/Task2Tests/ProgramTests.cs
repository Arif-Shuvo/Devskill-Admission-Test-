using NUnit.Framework;
using Task2;

namespace Task2Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("aaabbcc", 2, "ccaaabb")]
        [TestCase("aaaaaa", 6, "aaaaaa")]
        [TestCase("ababababab", 0, "ababababab")]
        [TestCase("ABABABABAB", 13, "BABABABABA")]
        public void Test1(string a, int b, string r)
        {
            var result = a.Rotate(b);
            Assert.AreEqual(r, result);
        }
    }
}