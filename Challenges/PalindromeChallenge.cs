using System;

namespace c_sharp_practice.Challenges
{
    class Palindrome
    {
        public void PalindromeChallenge()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (isPalindrome(word))
            {
                Console.WriteLine($"{word} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrome");
            }
        }

        public bool isPalindrome(string word)
        {
            char[] wordArray = word.Trim().ToLower().ToCharArray();
            Array.Reverse(wordArray);
            string reversedWord = new string(wordArray);
            return word == reversedWord;
        }
    }
}