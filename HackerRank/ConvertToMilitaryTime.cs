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
        private char[] RemoveChars = { 'M', 'A', 'P' };

        public string ConvertToMilitary(string s)
        {
            string result;
            string[] timeElements = s.Split(':');
            if (PM(s))
            {
                Add12(ref timeElements[0]);
            }
            result = string.Join(":", timeElements).Trim(RemoveChars);

            return result;
        }

        public void Add12(ref string s)
        {
            s = s == "12" ? "00" : (int.Parse(s) + 12).ToString();
        }
        
        public bool PM(string s)
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
