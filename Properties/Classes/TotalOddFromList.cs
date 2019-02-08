using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalQuestion.Properties.Classes
{
    public static class TotalOddFromList
    {
        //Method for getting a list of 10 numbers from the User
        public static List<int> GetDigitList()
        {
            Console.WriteLine("Input 10 integers:");
            List<int> digits = new List<int>();
            return _RequestInput(0, digits);
        }

        //helper method called recursively for each user request. 
        public static List<int> _RequestInput(int iteration, List<int> digits)
        {
            if (iteration < 10)
            {
                try
                {
                    Console.WriteLine("Integer " + (iteration + 1) + ":");
                    digits.Add(Convert.ToInt32(Console.ReadLine()));
                    iteration++;
                    _RequestInput(iteration, digits);
                }
                catch
                {
                    Console.WriteLine("integers Only");
                    _RequestInput(iteration, digits);
                }

            }
            return digits;
        }
        //gets sum of odd numbers
        public static int TotalOdd(List<int> digits)
        {
            int total = digits.Aggregate(0, (acc, x) =>
            {
                if (x % 2 == 1)
                {
                    acc = acc + x;
                }
                return acc;
            });
            return total;
        }
    }
}
