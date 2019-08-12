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
        private static char[] RemoveChars = { 'M', 'A', 'P' };

        public static string ConvertToMilitary(string s)
        {
            string result;

            string[] timeElements = s.Split(':');
            timeElements[0] = Add12(s, timeElements[0]);
            result = string.Join(":", timeElements).Trim(RemoveChars);

            return result;
        }

        private static string Add12(string time, string s)
        {
            if(PM(time))
            {
                s = s == "12" ? "12" : (int.Parse(s) + 12).ToString();
            }
            else
            {
                s = s == "12" ? "00" : s;
            }
            return s;
        }
        
        private static bool PM(string s)
        {
            if (s.ToUpper().Contains("PM"))
            {
                return true;
            }
            return false;
        }

        [Theory]
        [InlineData("07:05:45PM", "19:05:45")]
        [InlineData("12:00:00PM", "12:00:00")]
        [InlineData("07:08:15AM", "07:08:15")]
        [InlineData("12:00:00AM", "00:00:00")]
        public void ConvertToMilitaryTest(string test, string expected)
        {
            Assert.Equal(expected, ConvertToMilitary(test));
        }
    }
}
