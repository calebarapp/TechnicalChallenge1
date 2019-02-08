using System;
namespace TechnicalQuestion.Properties.Classes
{
    public static class FizzBuzz
    {
        public static void Fizzbuzz ()
        {

            Console.WriteLine("Enter a number, ideally between 50 and 100.");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int x = 0; x <= num;x++)
            {
                if( x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz!");
                }
                else if (x % 3 == 0 && x % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0 && x % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else Console.WriteLine(x);
            }
        }
    }
}
