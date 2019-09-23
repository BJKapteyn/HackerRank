using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class DayOfProgrammer
    {
        public static string dayOfProgrammer(int year)
        {
            if(year < 1919)
            {
                if(year % 4 == 0)
                {
                    return "12.09." + year;
                }
                else
                {
                    return "13.09." + year;
                }
            }
            else if(year >= 1919)
            {
                if(year % 4 == 0 || year % 400 == 0)
                {
                    return "12.09." + year;
                }
                else
                {
                    return "13.09." + year;
                }
            }
            
        }
    }

    public class DayOfProgrammerTest
    {
        [Theory] 
        [InlineData(2017, "13.09.2017")]
        [InlineData(1984, "12.09.1984")]
        [InlineData(1800, "12.09.1800")]
        public void DOPTest1(int year, string expected)
        {
            string actual = DayOfProgrammer.dayOfProgrammer(year);

            Assert.Equal(expected, actual);
        }
    }
}
