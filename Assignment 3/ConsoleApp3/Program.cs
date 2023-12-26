using System;

class PrimeSieve
{
    static void Main()
    {
        Console.WriteLine("Enter the upper limit to find prime numbers:");

        if (int.TryParse(Console.ReadLine(), out int limit) && limit >= 2)
        {
            bool[] isPrime = new bool[limit + 1];

            // Initialize all numbers as prime
            for (int i = 2; i <= limit; i++)
            {
                isPrime[i] = true;
            }

            // Apply the Sieve of Eratosthenes
            for (int i = 2; i <= Math.Sqrt(limit); i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= limit; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            // Print prime numbers
            Console.WriteLine($"Prime numbers between 1 and {limit} are:");

            for (int i = 2; i <= limit; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer greater than or equal to 2.");
        }
    }
}
