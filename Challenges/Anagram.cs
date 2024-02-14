using System;
using System.Runtime.CompilerServices;

namespace c_sharp_practice.Challenges
{
    class Anagram
    {
        public void AnagramChallenge()
        {
            Console.WriteLine("Enter the first word:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Enter the second word:");
            string word2 = Console.ReadLine();

            if (isAnagram(word1, word2))
            {
                Console.WriteLine($"{word2} is an anagram of {word1}");
            }
            else
            {
                Console.WriteLine($"{word2} is not an anagram of {word1}");
            }
        }

        public bool isAnagram(string word1, string word2)
        {
            char[] wordArray1 = word1.Trim().ToLower().ToCharArray();
            char[] wordArray2 = word2.Trim().ToLower().ToCharArray();

            Array.Sort(wordArray1);
            Array.Sort(wordArray2);

            string sortedWord1 = new string(wordArray1);
            string sortedWord2 = new string(wordArray2);

            return sortedWord1 == sortedWord2;
        }
    }
}