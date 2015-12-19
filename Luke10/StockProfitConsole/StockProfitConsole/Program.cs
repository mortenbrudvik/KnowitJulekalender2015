using System;
using System.IO;
using System.Linq;

namespace StockProfitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Array.ConvertAll(File.ReadAllLines("../../stockPrices.txt").
                Select(x=>x.Replace(".",",").Trim()).
                ToArray(), double.Parse);

            var firstArray = array.Take((array.Length / 2)).ToArray();
            var secondArray = array.Skip((array.Length / 2)).ToArray();

            var p1 = FindMaxProfit(firstArray);
            var p2 = FindMaxProfit(secondArray);

            var maxProfit = p1 + p2;

            Console.Out.WriteLine("" + maxProfit);
        }

        private static double FindMaxProfit(double[] prices)
        {
            var maxProfit = double.MinValue;
            var diff = 0.0;
            var lowestPrice = prices[0];

            for (var i = 1; i < prices.Length; i++)
            {
                diff += prices[i] - prices[i - 1];

                if (diff > maxProfit)
                    maxProfit = diff;

                if (!(prices[i] < lowestPrice)) continue;

                lowestPrice = prices[i];
                diff = 0;
            }
            return maxProfit;
        }
    }
}
