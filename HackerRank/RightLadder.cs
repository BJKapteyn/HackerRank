using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class RightLadder
    {
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string s = "";
                s += addChar(n - i, " ");
                s += addChar(i, "#");
                Console.WriteLine(s);
            }

        }
        private static string addChar(int spaces, string character)
        {
            string result = "";
            for(int i = 0; i < spaces; i++)
            {
                result += character;
            }
            return result;
        }
        
    }
}
