using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment2
{
    internal class PricesProfit
    {
        //You are given an array prices where prices[i] is the price of a given stock on the ith day.
        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.R
        //eturn the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

        static void Main(string[] args)
        {
            int[] prices = {10,3,8,9,2,3,8,10,1};
            int profit = 0;
            int min_price_index=0,max_price_index=0;
            for(int i=0;i<prices.Length-2;i++)
            {
                for(int j = i; j < prices.Length - 1; j++)
                {
                    if (profit < (prices[j] - prices[i]))
                    {
                        profit = prices[j] - prices[i];
                        min_price_index = i;
                        max_price_index=j;
                    }
                }
            }
            Console.WriteLine($"The total profit we gained by selling the stocks is:{profit}");
            Console.WriteLine($"We buy the goods on the day {min_price_index+1}");
            Console.WriteLine($"We can sell the goods on the day {max_price_index+1}");
        }
    }
}
