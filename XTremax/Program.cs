using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTremax
{
    class Program
    { /**
         * Please DO NOT change the code in Main.
         **/
        static void Main(string[] args)
        {

            TestAlgorithm(new int[] { 3, 1, 4, 5, 8, 5, 2, 3, 8, 2, 3, 5, 6 }, 7);
            TestAlgorithm(new int[] { 3, 5, 4, 5, 11, 5, 2, 2, 7, 2, 3, 5, 6 }, 8);
            TestAlgorithm(new int[] { 3, 5, 4, 5, 6, 5, 20, 1, 4, 2, 3, 15, 6 }, 17);
            TestAlgorithm(new int[] { 19, 19, 19, 19, 19, 19, 20, 1, 4, 2, 3, 15, 6 }, 14);
            TestAlgorithm(new int[] { 3, 5, 3, 19, 6, 5, 5, 1, 14, 3, 3, 6, 6 }, 16);
            TestAlgorithm(new int[] { 3, 5, 2, 5, 8, 5, 5, 1, 4, 3, 3, 5, 6 }, 6);
            TestAlgorithm(new int[] { 2, 5, 6, 5, 6, 5, 15, 5, 4, 1, 3, 7, 6 }, 13);
            TestAlgorithm(new int[] { 7, 5, 5, 4, 17, 5, 5, 1, 4, 3, 3, 12, 6 }, 13);
            TestAlgorithm(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 0);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        /**
         * Please DO NOT change the code in TestAlgorithm.
         **/
        private static void TestAlgorithm(int[] prices, int expectedAnswer)
        {
            int answer = CalculateMaximumProfit(prices);
            if (answer == expectedAnswer)
            {
                Console.WriteLine("Answer is correct");
            }
            else
            {
                Console.WriteLine("Answer is wrong.  Maximum Profit should be: " + expectedAnswer + " but your profit is: " + answer);
            }
        }

        /**
         Question 1
         * Write a method called CalculateMaximumProfit that takes in an integer array of prices and returns an integer output representing the maximum profit.
         * The array of prices represents the daily prices of a particular stock. This method should calculate the maximum profit of buying and selling the stock. 
         * Assume that we don't have any stock on hand now, so we have to buy first and sell later.
         * Let's say this is an array showing the daily prices of stock X:
         * [3, 1, 4, 5, 8, 5, 2, 3, 8, 2, 3, 5, 6]
         * The answer of the maximum profit would be 7. Because we buy on the second day and sell it on the fifth day. Note that if you buy on the fifth day,
         * you CANNOT sell at the prices of fouth, third... or other days that are passed and are before day five.
         **/
        public static int CalculateMaximumProfit(int[] prices)
        {
            int result = int.MinValue;

            //result = prices[i + 1] - prices[i];
            for (int i = 0; i < prices.Length; i++)
            {
                
                for (int j = i+1; j+1 < prices.Length; j++)
                {
                    result = prices[j] - prices[i] > result ? prices[j] - prices[i] : result;
                }
            }            
   
             return result;         

        }
    }
}
