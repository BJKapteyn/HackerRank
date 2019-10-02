using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //input, array of leaderboard scores and an array of Alice's placements on the leaderboard, duplicate scores share placement number
    class ClimbingLeaderboard
    {
        public static int[] climbingLeaderboard(long[] scores, long[] alice)
        {
            int[] scorePlacements = new int[alice.Length];
            List<long> scoresList = scores.Distinct().ToList();
            scoresList.Sort();
            scoresList.Reverse();

            for(int i = 0; i < alice.Length; i++)
            {
                //the find last index returns the index at which the score beating alice is
                //her actual scoreboard number is her actual index plus 1 so plus 2 overall
                int alicePlacement = scoresList.FindLastIndex(x => x > alice[i]) + 2;

                scorePlacements[i] = alicePlacement;
            }
            return scorePlacements;
        }

        public static int FindIndexReverseBinarySearch(long[] nums, long num)
        {
            int mid = 0;
            int highNumIndex = 0;
            int lowNumIndex = nums.Length - 1;
            if (num <= nums[lowNumIndex])
            {
                return lowNumIndex;
            }
            else if(num >= nums[highNumIndex])
            {
                return highNumIndex;
            }
            while (highNumIndex <= lowNumIndex)
            {
                mid = (lowNumIndex + highNumIndex) / 2;
                if (num == nums[mid])
                {
                    return mid;
                }
                else if (num > nums[mid + 1] && num < nums[mid - 1])
                {
                    break;
                }
                if (num < nums[mid])
                {
                    highNumIndex = mid + 1;
                }
                else
                {
                    lowNumIndex = mid - 1;
                }
            }
            if(num < nums[mid-1] && num > nums[mid])
            {
                return mid;
            }
            else if(num < nums[mid] && num > nums[mid+1])
            {
                return mid + 1;
            }
            return -1;
        }
        //public static int[] climbingLeaderboard(long[] scores, long[] alice)
        //{
        //    int[] scorePlacements = new int[alice.Length];
        //    List<long> scoresList = scores.ToList();
        //    //create scoreboard and remove duplicates and order the list
        //    List<Player> playerScoreboard = CreateScoreBoard(scores)
        //                                        .GroupBy(x => x.Score)
        //                                        .Select(x => x.First())
        //                                        .OrderByDescending(x => x.Score)
        //                                        .ToList();

        //    for(int i = 0; i < alice.Length; i++)
        //    {
        //        Player Alice = new Player("Alice", alice[i]);
        //        playerScoreboard.Add(Alice);
        //        playerScoreboard = playerScoreboard.OrderByDescending(x => x.Score).ToList();
        //        int scoreIndex = playerScoreboard.IndexOf(Alice);
        //        //if alice's score ties another score, add that placement instead, placement starts at 1, 2, 3 etc so actual placement is 
        //        //index + 1;
        //        try
        //        {
        //            if (playerScoreboard[scoreIndex - 1].Score == Alice.Score)
        //            {
        //                scorePlacements[i] = scoreIndex;
        //            }
        //            else
        //            {
        //                scorePlacements[i] = scoreIndex + 1;
        //            }
        //        }
        //        catch(ArgumentOutOfRangeException)
        //        {
        //            scorePlacements[i] = 1;
        //        }
        //        playerScoreboard.Remove(Alice);
        //    }

        //    return scorePlacements.ToArray();
        //}

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
        [InlineData(new long[] {100, 100, 50, 40, 40, 20, 10 }, new long[] {5, 25, 50, 120 }, new int[] {6, 4, 2, 1 })]
        [InlineData(new long[] { 100, 90, 90, 80, 75, 60 }, new long[] {50, 65, 77, 90, 102 }, new int[] { 6,5, 4, 2, 1})]
        public void ClimbingLeaderboardTest1(long[] scores, long[] alice, int[] expected)
        {
            int[] actual = ClimbingLeaderboard.climbingLeaderboard(scores, alice);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new long[] { 9, 8, 7, 6, 5, 3, 2, 1, 0}, 4, 5)]
        [InlineData(new long[] { 9, 8, 7, 6, 5, 4, 3, 2, 1}, 4, 5)]
        [InlineData(new long[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 10, 0)]
        [InlineData(new long[] { 90, 80, 70, 60, 50, 40, 30, 20, 10 }, 25, 7)]
        public void ClimbingLeaderboardBinaryTest1(long[] scores, long score, int expected)
        {
            int actual = ClimbingLeaderboard.FindIndexReverseBinarySearch(scores, score);

            Assert.Equal(expected, actual);
        }
    }
}
