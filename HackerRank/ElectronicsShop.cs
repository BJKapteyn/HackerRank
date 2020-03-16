using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //https://www.hackerrank.com/challenges/electronics-shop/problem
    class ElectronicsShop
    {
        public static int getMoneySpent(int[] keyboards, int[] drives, int money)
        {
            int result = -1;

            return result;
        }
    }
    public class ElectronicsShopTest
    {
        [Theory]
        [InlineData(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10, 9)]
        [InlineData(new int[] { 4 }, new int[] { 5}, 5, -1)]
        public static void ElectronicsShopTest1(int[] keyboards, int[] drives, int money, int expected)
        {
            int actual = ElectronicsShop.getMoneySpent(keyboards, drives, money);

            Assert.Equal(expected, actual);
        }
    }
}
