using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    public class ConvertToMilitaryTime
    {
        public string ConvertToMilitary(string s)
        {
            string result;
            string[] timeElements = s.Split(':');
            char[] removeChars = { 'M', 'A', 'P' };
            if (AmOrPm(s))
            {
                if(timeElements[0] == "12")
                {
                    timeElements[0] = "00";
                }
                else
                {
                    timeElements[0] = (int.Parse(timeElements[0]) + 12).ToString();
                }
            }
            result = string.Join(":", timeElements).Trim(removeChars);

            return result;
        }
        public bool AmOrPm(string s)
        {
            if (s.ToUpper().Contains("PM"))
            {
                return true;
            }
            return false;
        }

        [Theory]
        [InlineData("07:05:45PM", "19:05:45")]
        [InlineData("12:00:00PM", "00:00:00")]
        [InlineData("07:08:15AM", "07:08:15")]
        public void ConvertToMilitaryTest(string test, string expected)
        {
            Assert.Equal(expected, ConvertToMilitary(test));
        }
    }
}
