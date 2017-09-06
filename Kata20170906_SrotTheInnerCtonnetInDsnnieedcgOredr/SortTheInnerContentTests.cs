using System;
using System.Linq;
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

        [TestMethod]
        public void input_for_should_return_for()
        {
            SortTheInnerContentShouldBe("for", "for");
        }

        [TestMethod]
        public void input_sort_should_return_srot()
        {
            SortTheInnerContentShouldBe("srot", "sort");
        }

        [TestMethod]
        public void input_a_should_return_s()
        {
            SortTheInnerContentShouldBe("a", "a");
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
            if (words.Length < 3)
            {
                return words;
            }
            var content = words.Skip(1).Take(words.Length - 2);
            var sortContent = string.Concat(content.OrderByDescending(s => s));
            return words.First() + sortContent + words.Last();
        }
    }
}
