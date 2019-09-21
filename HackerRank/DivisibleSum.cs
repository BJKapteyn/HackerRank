using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class DivisibleSum
    {
        public static int divisibleSumPairs(int k, int[] ar, int n = 5)
        {
            int result = 0;

            return result;

        }
    }

    public class DivisibleSumTest
    {
        [Fact]
        public static void divisibleSumTest1()
        {
            int[] test = { 1, 3, 2, 6, 1, 2 };
            int expected = 5;
            int actual = DivisibleSum.divisibleSumPairs(3, test);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void divisibleSumTest2()
        {
            int[] test = { 1, 2, 3, 4, 5, 6};
            int expected = 3;
            int actual = DivisibleSum.divisibleSumPairs(5, test);

            Assert.Equal(expected, actual);
        }
    }
}
