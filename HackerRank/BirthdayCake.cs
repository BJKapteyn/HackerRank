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
        //Lily has a chocolate bar that she wants to share it with Ron for his birthday.Each of 
        //    the squares has an integer on it. She decides to share a contiguous segment of the 
        //    bar selected such that the length of the segment matches Ron's birth month and the 
        //    sum of the integers on the squares is equal to his birth day. You must determine 
        //    how many ways she can divide the chocolate.
        public static int Birthday(List<int> s, int day, int month)
        {
            int result = 0;
            int total = 0;
            for (int k = 0; k < s.Count - month + 1; k++)
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
