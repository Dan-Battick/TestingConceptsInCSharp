using System;

namespace UsingArrays
{
    class UsingArrays
    {
        static double[] ASquared(double[] baseArray)
        {
            double[] squaredArray = new double[6];
            for (int x = 0; x < baseArray.Length; x++)
            {
                squaredArray[x] = Math.Pow(baseArray[x], 2);
            }
            return squaredArray;
        }
        static void Main(string[] args)
        {
            double[] luckyNumbers = { 2, 3, 5, 7, 11, 13 };
            double[] luckyNumbersSq = ASquared(luckyNumbers);

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine($"{luckyNumbers[i]} squared = {luckyNumbersSq[i]}");
            }
        }
    }
}
