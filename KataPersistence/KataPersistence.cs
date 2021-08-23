using System;

namespace KataPersistence
{
    class KataPersistence
    {
        static void Main(string[] args)
        {
            int num = 635698;
            int count = 0;
            int mult = 1;
            /*while (num != 0)
            {
                count++;
                int lastDigit = num % 10;
                mult *= lastDigit; 
                num = num / 10;
            }*/
            Console.WriteLine(Math.Floor(Math.Log10(num) + 1));
            //Console.WriteLine(mult);
        }

        public static int MultiplyDigits(int n)
        {

            return -1;
        }
    }
}
