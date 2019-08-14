using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class AppleTree
    {
        //see how many apples[] and oranges[] (these contain fall distancesfrom startp position)
        //at positions 'a' and 'b' respectively fall on your house positioned between 's' and 't'.
        public int[] countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int[] result = { 0, 0 };

            foreach (int apple in apples)
            {
                if (isBetween(s, t, a + apple))
                {
                    result[0]++;
                }
            }
            foreach(int orange in oranges)
            {
                if(isBetween(s, t, b + orange))
                {
                    result[1]++;
                }
            }

            return result;
        }

        public bool isBetween(int min, int max, int x)
        {
            return x >= min && x <= max ? true : false;
        }
    }

    public class AppleTreeTest
    {
        [Fact]
        public void AppleTreeTest1()
        {
            AppleTree atree = new AppleTree();
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;
            int[] apples = { -2, 2, 1 };
            int[] oranges = { 5, -6};

            int[] expected = { 1, 1 };
            int[] actual = atree.countApplesAndOranges(s, t, a, b, apples, oranges);

            Assert.Equal(expected, actual);
        }
    }
}
