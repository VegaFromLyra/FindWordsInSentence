using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given a sentence without spaces and a 
// dictionary of valid words,
// print the valid words in the sentence
namespace FindWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> dictionary = new HashSet<string>();
            dictionary.Add("the");
            dictionary.Add("hen");

            string sentenceWithoutSpaces = "thehen";

            PrintWords(sentenceWithoutSpaces, dictionary);
        }

        static void PrintWords(string sentence, HashSet<string> dictionary)
        {
            int start = 0;
            int end = 0;

            while (start < sentence.Length && end < sentence.Length)
            {
                string word = sentence.Substring(start, end - start + 1);
                if (dictionary.Contains(word))
                {
                    Console.WriteLine(word);
                    end++;
                    start = end;
                }

                end++;
            }
        }
    }
}
