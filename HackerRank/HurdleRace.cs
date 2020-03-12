using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Linq;

namespace HackerRank
{
    //https://www.hackerrank.com/challenges/the-hurdle-race/problem
    //Dan is playing a video game in which his character competes in a hurdle race.Hurdles are of varying heights, 
    //and Dan has a maximum height he can jump.There is a magic potion he can take that will increase his maximum height
    //by unit 1 for each dose.How many doses of the potion must he take to be able to jump all of the hurdles.
    class HurdleRace
    {
        public static int hurdleRace(int jumpHeight, int[] hurdleHeights)
        {
            int potionsNeeded = hurdleHeights.Select(x => howManyPotions(jumpHeight, x))
                                             .ToArray()
                                             .Aggregate((x, y) => x + y);

            return potionsNeeded;
        }
        
        private static int howManyPotions(int jumpHeight, int hurdleHeight)
        {
            if(hurdleHeight > jumpHeight)
            {
                return hurdleHeight -= jumpHeight;
            }
            else
            {
                return 0;
            }
        }
    }

    public class HurdleRaceTest
    {
        [Fact] 
        public void HurdleRaceTest1()
        {
            int jumpHeight = 7;
            int[] hurdleHeights = { 2, 5, 4, 5, 2};

            int expected = 0;
            int actual = HurdleRace.hurdleRace(jumpHeight, hurdleHeights);

            Assert.Equal(expected, actual);
        }
    }
}
