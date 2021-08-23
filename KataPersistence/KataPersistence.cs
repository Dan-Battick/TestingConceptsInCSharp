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
            long num = 999;
            //Console.WriteLine($"The number of digits in { num } = { CountDigits(num) }");
            //Console.WriteLine($"The multiplication of all digits = { MultiplyDigits(num) }");
            Console.WriteLine($"The persistence of {num} is {Persistence(num)}");
        }

        public static int Persistence(long n)
        {
            int counter = 0;
            int digits = countDigits(n);
            while (digits > 1)
            {
                counter += 1;
                long mult = multiplyDigits(n);
                //Console.WriteLine($"The value of mult now is {mult}");
                n = mult;
                digits = countDigits(mult);
            }
            return counter;
        }

        private static int countDigits(long num)
        {
            /*
            // This loop can count for all integers, but takes a longer time
            int count = 0;
            while (num != 0)
            {
                num /= 10;
                ++count;
            }
            return count;*/

            return (int)Math.Floor(Math.Log10(num) + 1); // Does not work for 0 or negative numbers.
        }

        private static long multiplyDigits(long n)
        {
            long mult = 1;
            while (countDigits(n) > 1)
            {
                long lastDigit = n % 10;
                mult *= lastDigit;
                n /= 10;
            }
            return (long)(mult * n);
        }
    }
}
