using System;
using System.Linq;

namespace TechnicalQuestion.Properties.Classes
{
    public static class WordChallenges
    {
        public static string  Reverse()
        {
            Console.WriteLine("Input anything");
            string challengeThreeInput = Console.ReadLine();
            string challengeThreeInputReversed = "";

            for (int x = challengeThreeInput.Length - 1; x >= 0; x--)
            {
                challengeThreeInputReversed += challengeThreeInput[x];
            }
           return challengeThreeInputReversed;
        }

        public static string RemoveDuplicates()
        {
            Console.WriteLine("Input anything");
            string challengeFourInput = Console.ReadLine();
            string uniqueCharacters = "";

            for (int x = 0; x < challengeFourInput.Length; x++)
            {
                if (!uniqueCharacters.Contains(challengeFourInput[x]))
                {
                    uniqueCharacters += challengeFourInput[x];
                };
            }
            return uniqueCharacters;
        }
    }
}
