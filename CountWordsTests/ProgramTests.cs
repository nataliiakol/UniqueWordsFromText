using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountWords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SplitTextToWordsTest()
        {
            var text = "Go do that thing";
            string[] expectedWords = { "Go", "do", "that", "thing" };
            string[] actualWords = Program.SplitTextToWords(text);

            CollectionAssert.AreEqual(expectedWords, actualWords);
        }

        [TestMethod()]
        public void CountUniqueWordsTest()
        {
            string[] words = { "Go", "do", "do"};
            Dictionary<string, int> expectedUniqueWords = new Dictionary<string, int>{
                { "Go", 1 },
                { "do", 2 }
            };
            Dictionary<string, int> actualUniqueWords = Program.CountUniqueWords(words);
            CollectionAssert.AreEqual(expectedUniqueWords, actualUniqueWords);
        }
    }
}