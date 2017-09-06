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

        [TestMethod]
        public void input_sort_the_inner_content_in_descending_order()
        {
            SortTheInnerContentShouldBe("srot the inner ctonnet in dsnnieedcg oredr", "sort the inner content in descending order");
        }

        [TestMethod]
        public void input_wait_for_me()
        {
            SortTheInnerContentShouldBe("wiat for me", "wait for me");
        }

        [TestMethod]
        public void input_this_kata_is_easy()
        {
            SortTheInnerContentShouldBe("tihs ktaa is esay", "this kata is easy");
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
            return string.Join(" ", words.Split(' ').Select(SortContent));
        }

        private static string SortContent(string word)
        {
            if (word.Length < 3)
            {
                return word;
            }

            return word.First() + string.Concat(word.Skip(1).Take(word.Length - 2).OrderByDescending(s => s)) + word.Last();
        }
    }
}
