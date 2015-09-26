using System;
/*
 * n! means n × (n − 1) × ... × 3 × 2 × 1
 * 
 * For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
 * and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
 * 
 * Find the sum of the digits in the number 100!
 */
namespace PEProblem020
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int[] inputString = new int[200];
            inputString[0] = 1;
            int tmp = 0;
            for (int i = 2; i < 100; i++)
            {
                for (int j = 0; j < inputString.Length; j++)
                {
                    tmp = inputString[j] * i + tmp;
                    inputString[j] = tmp - (tmp / 10) * 10;
                    tmp = tmp / 10;
                }
            }
            
            int result = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                result += inputString[i];
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
