using System;
using c_sharp_practice.Challenges;

namespace c_sharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Action> challenges = new Dictionary<int, Action>()
            {
                {1, new FizzBuzz().FizzBuzzChallenge},
                {2, new Palindrome().PalindromeChallenge},
                {3, new Anagram().AnagramChallenge},
                {4, new Fibonacci().FibonacciChallenge},

            };

            while (true)
            {
                Console.WriteLine("\n___________________\n");
                Console.WriteLine("Choose a challenge:");
                foreach (var entry in challenges)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value.Method.Name}");
                }
                Console.WriteLine("0: Exit");
                Console.WriteLine("___________________\n");


                int choice;
                if (int.TryParse(Console.ReadLine(), out choice) && challenges.ContainsKey(choice))
                {
                    challenges[choice]();
                }
                else if (choice == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice,");
                }
            }
        }
    }
}