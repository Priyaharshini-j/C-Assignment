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
            int[] prices = { 4, 6, 2, 3, 1, 8, 5, 10 };
            int min_price = 1000,max_price = 0;
            calculate(prices, min_price, max_price);
            //calculate(prices1 , min_price, max_price);

        }
        public static void calculate(int[] prices, int min_price, int max_price)
        {
            int min_price_index=0, max_price_index=0;
            foreach(int price in prices)
            {
                if (price < min_price)
                {
                    min_price = price;
                }
                if (price > max_price)
                {
                    max_price = price;
                }
                             
            }

            min_price_index = Array.IndexOf(prices, min_price);
            max_price_index = Array.IndexOf(prices, max_price);
            Console.WriteLine(max_price_index);
            Console.WriteLine(min_price_index);

            if (min_price_index < max_price_index)
            {
                Console.WriteLine($"The Stock is brough on day{min_price_index+1} and sell it on {max_price_index+1}");
                Console.WriteLine($"The Profit is {max_price - min_price}");
            }
            else
            {
                var dest = new List<int>(prices);
                if (max_price_index == 0)
                {
                    if (max_price_index == prices.Length)
                    {

                        dest.RemoveAt(min_price_index);
                    }
                    dest.RemoveAt(max_price_index);
                    calculate(dest.ToArray(), 1000, 0);
                }
                }
        }

    }
}
