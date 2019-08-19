using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class BetweenArrays
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int result = 0;
            int low = a.Max();
            int high = b.Min();

            for (int i = low; i < high; i++)
            {
                
            }



            return result;
        }
    }

    public class BetweenArraysTest
    {
        [Fact]
        public void BetweenTest1()
        {
            int expected = 3;
            List<int> a = new List<int> { 2, 4 };
            List<int> b = new List<int> { 16, 32, 96 };
            int actual = BetweenArrays.GetTotalX(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
