using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{

    //John works at a clothing store.He has a large pile of socks that he must pair by color for sale.Given an array of integers representing 
    //the color of each sock, determine how many pairs of socks with matching colors there are.
    class MatchingPairs
    {
        public static int sockMerchant(int n, int[] ar)
        {
            int result = 0;


            return result;
        }
    }

    public class MatchingPairsTest
    {
        [Theory]
        [InlineData(new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
        public static void SockMerchantTest(int[] test, int expected)
        {
            int actual = MatchingPairs.sockMerchant(expected, test);

            Assert.Equal(expected, actual);
        }
    }
}
