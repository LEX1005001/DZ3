using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDZ3
{
    public class StringOperations
    {
        private string _text;

        public const string Vowels = "АУОЫЭЯЮЁИЕауоыэяюёие";

        public string Text { get => _text; set => _text = value; }

        /// <summary>
        /// Считает кол-во гласных букв в тексте
        /// </summary>
        /// <param name="text">Текст</param>
        /// <returns>Кол-во гласных букв в тексте</returns>
        public int findingVowels(string text)
        {
            int counter = 0;

            foreach( char c in text) 
            {
                if (Vowels.Contains(c))
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Переворот слова
        /// </summary>
        /// <param name="word">Cлово</param>
        /// <returns>Перевёрнутое слово</returns>
        public string ReverseString(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Переворачивает каждое слово в предложении
        /// </summary>
        /// <param name="text">Текст</param>
        /// <returns>Текст после операций</returns>
        public string ReverseWords(string text)
        {
            string[] words = text.Split(' ');
            string[] reversedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                reversedWords[i] = ReverseString(words[i]);
            }

            return string.Join(" ", reversedWords);
        }

        /// <summary>
        /// Изменять регистр первой буквы каждого предложения на букву в верхнем регистре
        /// </summary>
        /// <param name="text">сам текст</param>
        /// <returns>Текст после операций</returns>
        public string CapitalizeSentences(string text)
        {
            string[] sentences = text.Split('.');

            for (int i = 0; i < sentences.Length; i++)
            {
                string sentence = sentences[i].Trim();

                if (!string.IsNullOrEmpty(sentence))
                {
                    char firstChar = char.ToUpper(sentence[0]);
                    string restOfSentence = sentence.Substring(1);
                    sentences[i] = firstChar + restOfSentence;
                }
            }

            return string.Join(". ", sentences);
        }
    }
}
