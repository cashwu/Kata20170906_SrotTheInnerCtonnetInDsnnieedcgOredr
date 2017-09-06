using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void input_descending_should_return_dsnnieedcg()
        {
            SortTheInnerContentShouldBe("dsnnieedcg", "descending");
        }

        [TestMethod]
        public void input_i_am_should_return_i_am()
        {
            SortTheInnerContentShouldBe("i am", "i am");
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
            var wordsArray = words.Split(' ');

            var result = new List<string>();
            foreach (var word in wordsArray)
            {
                if (word.Length < 3)
                {
                    result.Add(word);
                    continue;
                }
                var content = word.Skip(1).Take(word.Length - 2);
                var sortContent = string.Concat(content.OrderByDescending(s => s));
                result.Add(word.First() + sortContent + word.Last());
            }

            return string.Join(" ", result);
        }
    }
}
