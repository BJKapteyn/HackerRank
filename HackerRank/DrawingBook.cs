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
        public static int pageCount(int n, int p)
        {
            int result = 0;

            return result;
        }
    }

    public class DrawingBookTest
    {
        [Theory]
        [InlineData (6, 2, 1)]
        public void DrawingBookTest1(int n, int p, int expected)
        {
            int actual = DrawingBook.pageCount(n, p);

            Assert.Equal(expected, actual);
        }
    }
}
