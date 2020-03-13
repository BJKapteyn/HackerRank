using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //https://www.hackerrank.com/challenges/counting-valleys/problem
    //guy starts at sea level and takes steps either uphill or downhill. Count the number of times he goes below sea level.
    class CountingValleys
    {
        public static int countingValleys(string pathSteps)
        {
            int result = 0;
            int previousStep = 0;
            int thisStep = 0;

            foreach(char x in pathSteps)
            {
                previousStep = thisStep;
                switch(x)
                {
                    case 'U':
                        thisStep++;
                        break;
                    case 'D':
                        thisStep--;
                        break;
                }

                if(thisStep < 0 && previousStep == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }

    public class CoutingValleys
    {
        [Theory]
        [InlineData("DDUUUUDD", 1)]
        [InlineData("UDDDUDUU", 1)]
        public void CountingValleysTest1(string pathSteps, int expected)
        {
            int actual = CountingValleys.countingValleys(pathSteps);
        }
    }
}
