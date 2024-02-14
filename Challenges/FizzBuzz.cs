using System;

namespace c_sharp_practice.Challenges
{
    class FizzBuzz
    {
        public void FizzBuzzChallenge()
        {
            // Get the user input for a starting number
            Console.Write("Enter the starting number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            // Get the user input for an ending number
            Console.Write("Enter the ending number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            // Get the user input for the first dividing number
            Console.Write("Enter the first devisor: ");
            int devisor1 = Convert.ToInt32(Console.ReadLine());

            // Get the user input for the second dividing number
            Console.Write("Enter the second devisor: ");
            int devisor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("FizzBuzz results:");

            // Create a for loop to start and end at the user's specified numbers
            for (int i = start; i <= end; i++)
            {
                string output = "";
                bool fizz = i % devisor1 == 0;
                bool buzz = i % devisor2 == 0;

                if (fizz)
                {
                    output += "Fizz";
                }

                if (buzz)
                {
                    output += "Buzz";
                }

                if (!fizz && !buzz)
                {
                    output += Convert.ToString(i);
                }

                Console.WriteLine(output);
            }
        }
    }
}