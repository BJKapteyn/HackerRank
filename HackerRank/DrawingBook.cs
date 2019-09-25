using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //find the lowest amount of page turns for a book with p pages and a page number of n
    class DrawingBook
    {
        public static int pageCount(int n, int p = 0)
        {
            int result = 0;
            int fromFront = 0;
            int fromBack = 0;
            if(n == p)
            {
                return 0;
            }


            fromFront = n / 2;

            if(p % 2 == 0)
            {
                p++;
            }

            fromBack = (p - n) / 2;
            
            List<int> frontAndBack = new List<int>() { fromFront, fromBack };
            result = frontAndBack.Min();
            return result;
        }
    }

    public class DrawingBookTest
    {
        [Theory]
        [InlineData (2, 6, 1)]
        [InlineData(4, 5, 0)]
        public void DrawingBookTest1(int n, int p, int expected)
        {
            int actual = DrawingBook.pageCount(n, p);

            Assert.Equal(expected, actual);
        }
    }
}
