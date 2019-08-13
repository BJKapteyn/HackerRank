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

        public static long[] Leaderboard(long[] leaderboard, long[] aliceScores)
        {
            List<long> lbPacements = new long[leaderboard.Length + 1].ToList();
            long[] aPlacements = new long[aliceScores.Length];
            List<long> tempLB = leaderboard.ToList();
            
            for(long i = 0; i < aliceScores.Length; i++)
            {
                long count = 1;
                tempLB.Add(aliceScores[i]);
                tempLB.Sort();
                tempLB.Reverse();

                int alicePostion = tempLB.IndexOf(aliceScores[i]);

                lbPacements[0] = count;
                for(int k = 1; k < lbPacements.Count; k++)
                {
                    if (tempLB[k] != tempLB[k - 1])
                    {
                        count++;
                    }
                    lbPacements[k] = count;
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
            long[] expected = { 2, 4, 4, 2 };
            long[] test = { 60, 10, 20, 50 };
            long[] leaderboard = { 62, 50, 25, 10 };
            long[] actual = Arcade.Leaderboard(leaderboard, test);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArcadeTest2()
        {
            long[] expected = { 6, 5, 4, 2, 1 };
            long[] test = { 50, 65, 77, 90, 102 };
            long[] leaderboard = { 100, 90, 90, 80, 75, 60 };
            long[] actual = Arcade.Leaderboard(leaderboard, test);

            Assert.Equal(expected, actual);
        }
    }
}
