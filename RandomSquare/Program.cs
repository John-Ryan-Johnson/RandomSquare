using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var randomNumberList = new List<int>();

            var squaredNumberList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                var randomNumber = random.Next(1, 51);
                randomNumberList.Add(randomNumber);
                squaredNumberList.Add(randomNumber * randomNumber);
            }
            Console.WriteLine($"Random numbers: {string.Join(", ", randomNumberList)}");

            Console.WriteLine();

            Console.WriteLine($"Squared random numbers: {string.Join(", ", squaredNumberList)}");

            Console.WriteLine();

            var evenSquaredNumbers = new List<int>();

            foreach (var number in squaredNumberList)
            {
                if (number % 2 == 0)
                {
                    evenSquaredNumbers.Add(number);
                }
            }

            Console.WriteLine($"Even squared numbers: {string.Join(", ", evenSquaredNumbers)}");
        }
    }
}
