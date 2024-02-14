using System;

namespace c_sharp_practice.Challenges
{
    class Fibonacci
    {
        public void FibonacciChallenge()
        {
            Console.Write("Enter the number of Fibonacci numbers you want to generate: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            FibonacciMemoization(numberOfElements);
        }

        public int FibonacciMemoization(int n, Dictionary<int, int> memo = null)
        {
            if (memo == null) memo = new Dictionary<int, int>();

            if (memo.ContainsKey(n)) return memo[n];
            if (n <= 1) return n;

            int result = FibonacciMemoization(n - 1, memo) + FibonacciMemoization(n - 2, memo);
            memo[n] = result;
            return result;
        }
    }
}