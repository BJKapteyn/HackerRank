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
            //basketball player wants to see how many times they've set their personal highest score per game
            //and personal lowest score per game. Returned is an array with number of times highest is broken and lowest respectively

            int[] result = { 0, 0 };
            int lowest = -1;
            int highest = -1;

            foreach(int score in scores)
            {
                if (lowest < 0 && highest < 0)
                {
                    lowest = score;
                    highest = score;
                    continue;
                }
                if (score > highest)
                {
                    highest = score;
                    result[0]++;
                }
                else if (score < lowest)
                {
                    lowest = score;
                    result[1]++;
                }
            }

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

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BreakingRecordsTest2()
        {
            int[] test = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            int[] expected = { 2, 4 };
            int[] actual = BreakingRecords.breakingRecords(test);

            Assert.Equal(expected, actual);
        }
    }
}
