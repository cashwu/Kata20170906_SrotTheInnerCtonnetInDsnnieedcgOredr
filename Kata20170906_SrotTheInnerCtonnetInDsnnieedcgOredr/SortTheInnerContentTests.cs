using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170906_SrotTheInnerCtonnetInDsnnieedcgOredr
{
    [TestClass]
    public class SortTheInnerContentTests
    {
        [TestMethod]
        public void input_me_should_return_me()
        {
            SortTheInnerContentShouldBe("me", "me");
        }

        private static void SortTheInnerContentShouldBe(string expected, string words)
        {
            var kata = new Kata();
            var actual = kata.SortTheInnerContent(words);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string SortTheInnerContent(string words)
        {
            return words;
        }
    }
}
