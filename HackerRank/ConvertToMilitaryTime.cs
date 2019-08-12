using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class ConvertToMilitaryTime
    {
        public string ConvertToMilitary(string s)
        {
            string result;
            string[] timeElements = s.Split(':');
            char[] remove = { 'M', 'A', 'P' };
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
            result = String.Join(":", timeElements).Trim(remove);

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
    }
}
