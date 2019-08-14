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
            int[] appleDis = apples.Select(x => x += a).ToArray();
            int[] orangeDis = oranges.Select(x => x += b).ToArray();

            foreach (int apple in appleDis)
            {
                if (isBetween(s, t, apple))
                {
                    result[0]++;
                }
            }
            foreach(int orange in orangeDis)
            {
                if(isBetween(s, t, orange))
                {
                    result[1]++;
                }
            }

            return result;
        }

        public int[] tallyRoofFruit(int[] fruit, int[] result, int index, int low, int high)
        {
            foreach(int f in fruit)
            {
                if (isBetween(low, high, f))
                {
                    result[index]++;
                }
            }
            return result;
        }

        public bool isBetween(int low, int high, int x)
        {
            return x >= low && x <= high ? true : false;
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
