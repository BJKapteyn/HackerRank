using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class Arcade
    {
        //alice is playing an arcade game, array one contains the scores of the game currently and the second is alices scores.
        //find where she is positioned within the high scores and return an array of each of the placements.

        public static List<int> Leaderboard(int[] leaderboard, int[] aliceScores)
        {
            List<int> lbPacements = new int[leaderboard.Length + 1].ToList();
            List<int> aPlacements = new int[aliceScores.Length].ToList();
            List<int> tempLB = leaderboard.ToList();
            
            for(int i = 0; i < aliceScores.Length; i++)
            {
                int count = 1;
                tempLB.Add(aliceScores[i]);
                tempLB.Sort();
                tempLB.Reverse();

                int alicePostion = tempLB.IndexOf(aliceScores[i]);

                lbPacements[0] = count;
                for(int k = 1; k < lbPacements.Count; k++)
                {
                   lbPacements[k] = lbPacements[k] ==  lbPacements[k - 1]?
                                    count : ++count;
                }
                aPlacements[i] = lbPacements[alicePostion];
                tempLB.RemoveAt(alicePostion);
            }

            return aPlacements;
        }
    }
    public class ArcadeTest
    {
        [Fact]
        public void ArcadeTest1()
        {
            List<int> expected = new List<int>{ 2, 4, 4, 2 };
            int[] test = { 60, 10, 20, 50 };
            int[] leaderboard = { 62, 50, 25, 10 };
            List<int> actual = Arcade.Leaderboard(leaderboard, test);

            Assert.Equal(expected, actual);
        }
    }
}
