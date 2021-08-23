using System;

namespace KataPersistence
{
    /// <summary>
    /// Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, 
    /// which is the number of times you must multiply the digits in num until you reach a single digit.
    /// </summary>
    class KataPersistence
    {
        static void Main(string[] args)
        {
            long num = 2425693232143635;
            //Console.WriteLine(CountDigits(num));
            Console.WriteLine(MultiplyDigits(num));
        }

        public static int CountDigits(long num)
        {
            // This loop can count for all integers, but takes a longer time
            /*int count = 0;
            while (num != 0)
            {
                num /= 10;
                ++count;
            }
            return count;*/

            return Convert.ToInt32(Math.Floor(Math.Log10(num) + 1)); // Does not work for 0 or negative numbers.
        }

        public static int MultiplyDigits(long n)
        {
            int mult = 1;
            while (CountDigits(n) > 1)
            {
                int lastDigit = Convert.ToInt32(n % 10);
                mult *= lastDigit;
                n /= 10;
            }
            return mult * (int) n;
        }
    }
}
