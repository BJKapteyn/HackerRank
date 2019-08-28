using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class BirthdayCake
    {
        //input list of numbers with 
        public static int Birthday(List<int> s, int day, int month)
        {
            int result = 0;
            int total = 0;
            for (int k = 0; k < s.Count - month; k++)
            {
                for (int i = k; i < k + month; i++)
                {
                    total += s[i];
                }
                if (total == day)
                {
                    result++;
                }
                total = 0;
            }

            return result;

        }
    }

    public class BirthdayCakeTest
    {
        [Fact]
        public void BirthdayCakeTest1()
        {
            List<int> test = new List<int> { 1, 2, 1, 3, 2 };
            int expected = 2;
            int actual = BirthdayCake.Birthday(test, 3, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BirthdayCakeTest2()
        {
            List<int> test = new List<int> { 1, 1, 1, 1, 1, 1 };
            int expected = 0;
            int actual = BirthdayCake.Birthday(test, 3, 2);

            Assert.Equal(expected, actual);
        }
    }
}
