using System;
using System.Collections.Generic;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            var result = new List<List<string>>();
            var sentence = new List<string>();
            var word = "";
            foreach (var symbol in text)
            {
                if (symbol == '.' || symbol == '!' || symbol == '?' || symbol == ';' || symbol == ':' || symbol == '(' || symbol == ')')
                {
                    //sentence.Add(word);
                    sentence = new List<string>();
                }
                else if (symbol == ' ')
                {
                    sentence.Add(word);
                    word = "";
                }
                else word += symbol;
            }
            return sentencesList;
        }
    }
}