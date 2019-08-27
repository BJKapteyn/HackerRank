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
        //basketball player wants to see how many times they've set their personal highest score per game
        //and personal lowest score per game. Returned is an array with number of times highest is broken and lowest respectively
        public static int[] breakingRecords(int[] scores)
        {

            int[] result = { 0, 0 };
            int lowScore = -1;
            int highScore = -1;

            foreach(int score in scores)
            {
                if (lowScore < 0 && highScore < 0)
                {
                    lowScore = score;
                    highScore = score;
                    continue;
                }
                if (score > highScore)
                {
                    highScore = score;
                    result[0]++;
                }
                else if (score < lowScore)
                {
                    lowScore = score;
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
