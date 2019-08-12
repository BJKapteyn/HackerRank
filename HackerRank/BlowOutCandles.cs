using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    /*
     * You are in charge of the cake for your niece's birthday and have decided the cake will have one candle for each year of her total age. When she 
     * blows out the candles, she’ll only be able to blow out the tallest ones. Your task is to find out how many candles she can successfully blow out.
     * For example, if your niece is turning 4 years old, and the cake will have candles of height 4, 4, 2, 1, she will be able to blow out candles 
     * successfully, since the tallest candles are of height 4 and there are 2 such candles. 
     */
    public class BlowOutCandles
    {
        public static int howManyCandles(int[] arr)
        {
            int max = arr.Max();
            int[] result = arr.Where(x => x == max).ToArray();
            return result.Length;
        }

        [Fact] 
        public static void CandleTest()
        {
            int result = 2;
            int[] test = { 3, 2, 1, 3 };

            Assert.Equal(result, howManyCandles(test));

        }
    }
}
