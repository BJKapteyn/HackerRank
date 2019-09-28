using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //input, array of leaderboard scores and an array of Alice's
    class ClimbingLeaderboard
    {
        public static int[] climbingLeaderboard(long[] scores, long[] alice)
        {
            int[] scorePlacements = new int[alice.Length];
            List<long> scoresList = scores.ToList();
            //create scoreboard and remove duplicates
            List<Player> playerScoreboard = CreateScoreBoard(scores).Distinct().ToList();

            for(int i = 0; i < alice.Length; i++)
            {
                Player Alice = new Player("Alice", alice[i]);
                playerScoreboard.Add(Alice);
                playerScoreboard.OrderBy(x => x.Score);
                int scoreIndex = playerScoreboard.IndexOf(Alice);
                //if alice's score ties another score, add that placement instead, placement starts at 1, 2, 3 etc so actual placement is 
                //index + 1;
                if(playerScoreboard[scoreIndex - 1].Score == Alice.Score)
                {
                    scorePlacements[i] = scoreIndex;
                }
                else
                {
                    scorePlacements[i] = scoreIndex + 1;
                }
            }

            return scorePlacements.ToArray();
        }

        public static List<Player> CreateScoreBoard(long[] scores)
        {
            List<Player> scoreBoard = new List<Player>();
            foreach(long score in scores)
            {
                Player player = new Player(score);
                scoreBoard.Add(player);
            }
            return scoreBoard;
        }
    }
    public class Player
    {
        public string Name { get; set; } = "OtherPlayer";
        public long Score { get; set; }

        public Player(string name, long score)
        {
            Name = name;
            Score = score;
        }
        public Player(long score)
        {
            Score = score;
        }
    }

    public class ClimbingLeaderboardTest
    {
        [Theory] 
        public void ClimbingLeaderboardTest1()
    }
}
