using System.IO;
using System.Collections.Generic;

namespace Dictionary
{
    public class Word
    {
        public Word(string foreignWord, string russianWord)
        {
            ForeignWord = foreignWord;
            RussianWord = russianWord;
        }

        public string ForeignWord { get; set; }
        public string RussianWord { get; set; }

        public static List<Word> CreateDictionary(StreamReader fileStream)
        {
            List<Word> words = new List<Word>();

            string currentWord;

            while ((currentWord = fileStream.ReadLine()) != null)
            {
                words.Add(new Word(currentWord.Split('-')[0], currentWord.Split('-')[1]));
            }

            fileStream.Close();
            
            return words;
        }
    }
}
