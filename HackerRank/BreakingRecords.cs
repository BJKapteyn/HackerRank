using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class BreakingRecords
    {
        public static int[] breakingRecords(int[] scores)
        {
            int[] result = new int[2];

            return result;

        }
    }

    public class BreakingRecordsTest
    {
        [Fact]
        public void BreakingRecordsTest1()
        {
            int[] test = { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            int[] expected = { 4, 0 };
            int[] actual = BreakingRecords.breakingRecords(test);

        }
    }
}
