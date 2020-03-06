using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{

    class TwoSubstring
    {
        //https://www.hackerrank.com/challenges/two-strings/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
        //Given two strings, determine if they share a common substring. A substring may be as small as one character.

        //For example, the words "a", "and", "art" share the common substring. The words "be" and "cat" do not share a substring. 
        public static bool HasSubstring(string string1, string string2)
        {
            bool result = false;

            string string1Distinct = new String(string1.Distinct().ToArray());
            string string2Distinct = new String(string2.Distinct().ToArray());
            

            foreach(char a in string1Distinct) 
            {
                foreach(char b in string2Distinct)
                {
                    if(a == b)
                    {
                        return true;
                    }
                }
            }

            return result;
        }
    }

    public class TwoSubtringTest
    {
        [Theory] 
        [InlineData("hello", "world", true )]
        [InlineData("jackandjill", "wentupthehill", true)]
        [InlineData("writetoyourparents", "fghmqzldbc", false)]

        public void TwoSubstringTest1(string string1, string string2, bool expected)
        {
            bool actual = TwoSubstring.HasSubstring(string1, string2);

            Assert.Equal(expected, actual);
        }
    }
}
