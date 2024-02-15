using System;

namespace c_sharp_practice.Challenges
{
    class Fibonacci
    {
        public void FibonacciChallenge()
        {
            Console.Write("Enter the index of the Fibonacci number you want: ");
            int index = Convert.ToInt32(Console.ReadLine());

            GetFibbonacciNumber(index);
        }

        public int GetFibbonacciNumber(int index, Dictionary<int, int> memo = null)
        {
            if (memo == null)
            {
                memo = new Dictionary<int, int>();
            }

            if (memo.ContainsKey(index))
            {
                return memo[index];
            }

            if (index <= 1)
            {
                return index;
            }

            int result = GetFibbonacciNumber(index - 1, memo) + GetFibbonacciNumber(index - 2, memo);

            memo[index] = result;

            return result;
        }
    }
}