using System;
using System.Collections.Generic;

namespace TechnicalQuestion.Properties.Classes
{
    public static class TotalAllFromList
    {
        //gets inputs from user and converst them to long
        public static List<long> GetLongDigitList()
        {
            Console.WriteLine("Input 10 integers:");
            List<long> digits = new List<long>();
            return _RequestInput(0, digits);
        }
        //helper method called recursively for each user request
        public static List<long> _RequestInput(int iteration, List<long> digits)
            {
                if(iteration < 10) { 
                    try
                    {
                        Console.WriteLine("Integers " + (iteration + 1) + ":");
                        digits.Add(Convert.ToInt64(Console.ReadLine()));
                        iteration++;
                        _RequestInput(iteration, digits);
                }
                    catch
                    { 
                        Console.WriteLine("Integers Only");
                        _RequestInput(iteration, digits);
                    }

                }
            return digits;
        }
        //Totals each item in the list
        public static long TotalAll(List<long> digits)
        {
            long total = 0;
            foreach (var x in digits)
            {
                total += x;
            }
            return total;
        }
    }
}
