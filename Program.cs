using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalQuestion.Properties.Classes;

namespace TechnicalQuestion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //First Challenge: 
            //Given an array of integers, write a method to total the odd numbers.

            Console.WriteLine("==================================================");
            Console.WriteLine("Challenge 1: ");
            Console.WriteLine("Given an array of integers, write a method to total the odd numbers.");
            Console.WriteLine("==================================================\n");

            List<int> Digits = TotalOddFromList.GetDigitList();
            int total = TotalOddFromList.TotalOdd(Digits);
            Console.WriteLine("The sum of odd numbers in your list is: " + total);

            //End First Challenge

            //Second Challenge: 
            //Given an array of integers, write a method to sum the elements in the array,
            //knowing that some of the elements may be very large integers.

            Console.WriteLine("==================================================");
            Console.WriteLine("Challenge Two: ");
            Console.WriteLine("Given an array of integers," +
            	" write a method to sum the elements in the array, knowing that some of the elements may be very large integers.");
            Console.WriteLine("==================================================\n");

            List<long> DigitsLong = TotalAllFromList.GetLongDigitList();
            long totalLong = TotalAllFromList.TotalAll(DigitsLong);
            Console.WriteLine("The sum of odd numbers in your list is: " + totalLong);

            //End Second Challenge

            //Third Challenge
            //Given a string, reverse it
            Console.WriteLine("==================================================");
            Console.WriteLine("Challenge Three: \n Reverse an input string:");
            Console.WriteLine("==================================================\n");

            string challengeThree = WordChallenges.Reverse();
            Console.WriteLine(challengeThree);


            //End Third Challenge

            //fourth Challenge
            //Remove Duplicates

            Console.WriteLine("==================================================");
            Console.WriteLine("Challenge four: \n Remove duplicates from an input string.");
            Console.WriteLine("==================================================\n");

            string challengeFour = WordChallenges.RemoveDuplicates();
            Console.WriteLine(challengeFour);

            //end Fourth Challenge

            //Fifth Challenge
            //Fizz buzz 

            Console.WriteLine("==================================================");
            Console.WriteLine("Challenge Five: \n FizzBizz!");
            Console.WriteLine("==================================================\n");
            FizzBuzz.Fizzbuzz();
        }

    }
}
