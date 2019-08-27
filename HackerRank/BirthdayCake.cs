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


            return result;

        }
    }

    public class BirthdayCakeTest
    {
        [Fact]

        public void BirthdayCakeTest1()
        {
            List<int> test = new List<int> { 1, 2, 1, 3, 2, };
            int expected = 0;
            int actual = BirthdayCake.Birthday(test, 3, 2);

            Assert.Equal(expected, actual);
           
        }

    }
}
