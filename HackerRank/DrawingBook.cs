using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //find the lowest amount of page turns for a book with n pages and a page number of p
    class DrawingBook
    {
        public static int pageCount(int n, int p = 0)
        {
            int result = 0;
            int fromFront = 0;
            int fromBack = 0;
            if(p == n)
            {
                return 0;
            }
            if(n % 2 == 0)
            {
                n++;
            }

            fromFront = p / 2;
            fromBack = (n - p) / 2;
            
            List<int> frontAndBack = new List<int>() { fromFront, fromBack };
            result = frontAndBack.Min();
            return result;
        }
    }

    public class DrawingBookTest
    {
        [Theory]
        [InlineData (6, 2, 1)]
        [InlineData(5, 4, 0)]
        [InlineData(14, 7, 3)]
        [InlineData(14, 8, 3)]
        public void DrawingBookTest1(int n, int p, int expected)
        {
            int actual = DrawingBook.pageCount(n, p);

            Assert.Equal(expected, actual);
        }
    }
}
