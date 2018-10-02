using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Go do that thing; that you do so well";
            IEnumerable<string> words = SplitTextToWords(text);
            Dictionary<string, int> uniqueWords = CountUniqueWords(words);
            Print(uniqueWords);
        }

        private static IEnumerable<string> SplitTextToWords(string text)
        {
            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = text.Split().Select(x => x.Trim(punctuation));
            return words;
        }

        private static void Print(Dictionary<string, int> uniqueWords)
        {
            foreach (KeyValuePair<string, int> kvp in uniqueWords)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            Console.ReadKey();
        }

        private static Dictionary<string, int> CountUniqueWords(IEnumerable<string> words)
        {
            Dictionary<string, int> uniqueWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (uniqueWords.ContainsKey(word))
                {
                    uniqueWords[word]++;
                }
                else
                {
                    uniqueWords.Add(word, 1);
                }
            }
            return uniqueWords;
        }

    }
}
