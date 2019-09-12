using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class MigratoryBirds
    {
        public static int MigBirds(int[] birds)
        {
            int result = 0;

            return result;
        }
    }

    public class MigratoryBirdsTest
    {
        [Fact]
        public static void MigTest1()
        {
            int[] test = { 1, 4, 4, 4, 5, 3 };
            int expected = 4;
            int actual = MigratoryBirds.MigBirds(test);

            Assert.Equal(expected, actual);
        }
    }
}
