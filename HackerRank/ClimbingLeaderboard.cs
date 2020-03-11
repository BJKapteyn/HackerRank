using System;
using System.Collections;
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

            for (int i = 0; i < alice.Length; i++)
            {
                //the find last index returns the index at which the score beating alice is
                //her actual scoreboard number is her actual index plus 1 so plus 2 overall

                scorePlacements[i] = FindIndexReverseBinarySearch(scoresList, alice[i]) + 1;
            } 
            return scorePlacements;
        }

        public static int FindIndexReverseBinarySearch(List<long> nums, long num)
        {
            int mid = 0;
            int highNumIndex = 0;
            int lowNumIndex = nums.Count - 1;
            if (num < nums[lowNumIndex])
            {
                return lowNumIndex + 1;
            }
            else if(num == nums[lowNumIndex])
            {
                return lowNumIndex;
            }
            else if (num >= nums[highNumIndex])
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
                else if(mid == 0)
                {
                    return 1;
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
            if (num < nums[mid - 1] && num > nums[mid])
            {
                return mid;
            }
            else if (num < nums[mid] && num > nums[mid + 1])
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

        //    public static List<Player> CreateScoreBoard(long[] scores)
        //    {
        //        List<Player> scoreBoard = new List<Player>();
        //        foreach(long score in scores)
        //        {
        //            Player player = new Player(score);
        //            scoreBoard.Add(player);
        //        }
        //        return scoreBoard;
        //    }
        //}
        //public class Player
        //{
        //    public string Name { get; set; } = "OtherPlayer";
        //    public long Score { get; set; }

        //    public Player(string name, long score)
        //    {
        //        Name = name;
        //        Score = score;
        //    }
        //    public Player(long score)
        //    {
        //        Score = score;
        //    }
        //}
    }
    public class ClimbingLeaderboardTestData : IEnumerable<object[]>
    {
        public static List<long> data1 = new List<long>() { 9, 8, 7, 6, 5, 3, 2, 1, 0 };
        public static List<long> data2 = new List<long>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        public static List<long> data3 = new List<long>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        public static List<long> data4 = new List<long>() { 90, 80, 70, 60, 50, 40, 30, 20, 10 };
        private readonly List<object[]> Data = new List<object[]>
        {
            new object[] { data1, (long)4, (long)5 },
            new object[] { data2, (long)4, (long)5 },
            new object[] { data3, (long)10, (long)0 },
            new object[] {data4, (long)25, (long)7 }
        };
        public IEnumerator<object[]> GetEnumerator() => Data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class ClimbingLeaderboardTest
    {
        [Theory]
        [InlineData(new long[] { 100, 100, 50, 40, 40, 20, 10 }, new long[] { 5, 25, 50, 75, 120 }, new int[] { 6, 4, 2, 2, 1 })]

        [InlineData(new long[] { 100, 100, 50, 40, 40, 20, 10 }, new long[] { 5, 25, 50, 120 }, new int[] { 6, 4, 2, 1 })]
        [InlineData(new long[] { 100, 90, 90, 80, 75, 60 }, new long[] { 50, 65, 77, 90, 102 }, new int[] { 6, 5, 4, 2, 1 })]
        [InlineData(new long[]
                    {
                        997, 981, 957, 933, 930, 927, 926, 920, 916, 896, 887, 874, 863, 863, 858, 847, 815, 809, 803, 794, 789, 785, 783, 778, 764, 755, 751, 740, 737, 730, 691, 677, 652, 650, 587, 585, 583, 568, 546, 541, 540, 538, 531, 527, 506, 493, 457, 435, 430, 427, 422, 422, 414, 404, 400, 394, 387, 384, 374, 371, 369, 369, 368, 365, 363, 337, 336, 328, 325,316, 314, 306, 282, 277, 230, 227, 212, 199, 179, 173, 171, 168, 136, 125, 124, 95,92, 88, 85, 70, 68, 61, 60, 59, 44, 43, 28, 23, 13, 12
                    }, 
                    new long[]
                    {
                        12, 20, 30, 32, 35, 37, 63, 72, 83, 85, 96, 98, 98, 118, 122, 125, 129, 132, 140, 144, 150, 164, 184, 191, 194, 198, 200, 220, 228, 229, 229, 236, 238, 246, 259, 271, 276, 281, 283, 287, 300, 302, 306, 307, 312, 318, 321, 325, 341, 341, 341, 344, 349, 351, 354, 356, 366, 369, 370 ,379 ,380, 380, 396, 405, 408, 417, 423, 429, 433 ,435 ,438, 441, 442, 444, 445, 445, 452 ,453, 465, 466, 467, 468, 469, 471, 475, 482, 489, 491 ,492 ,493, 498, 500, 501, 504, 506, 508, 523, 529, 530, 539, 543, 551, 552, 556, 568, 569, 571, 587, 591, 601 ,602, 606, 607, 612, 614, 619, 620, 623, 625, 625, 627, 638, 645, 653, 661, 662, 669, 670, 676, 684, 689, 690, 709, 709, 710, 716, 724, 726, 730, 731, 733, 737, 744, 744, 747, 757, 764, 765, 765, 772, 773, 774, 777, 787, 794, 796, 797, 802, 805, 811 ,814, 819, 819, 829 ,830, 841, 842, 847, 857, 857, 859, 860, 866, 872, 879, 882, 895, 900, 900, 903, 905, 915, 918, 918, 922, 925, 927, 928, 929, 931 ,934, 937, 955, 960, 966, 974, 982, 988, 996, 996
                    },
                    new int[]
                    {
                        97, 96, 94, 94, 94, 94, 89, 87, 87, 86, 83, 83, 83, 83, 83, 81, 81 ,81 ,80, 80, 80, 80, 76, 76, 76, 76, 75, 74, 73, 73, 73, 72, 72, 72, 72, 72, 72, 71, 70, 70, 70, 70, 69, 69, 69, 67, 67, 66, 63, 63, 63, 63 ,63, 63, 63, 63, 61, 59, 59, 57, 57, 57, 54, 52, 52, 51, 50, 49, 48, 47, 47, 47, 47, 47, 47, 47, 47, 47, 46, 46, 46, 46, 46, 46, 46,46, 46, 46, 46, 45, 45, 45, 45, 45, 44, 44, 44, 43, 43, 41, 39, 38, 38, 38, 37, 37, 37, 34,34, 34, 34, 34, 34,34,34, 34,34, 34, 34, 34, 34, 34, 34, 32, 32, 32, 32 ,32, 32, 31, 31, 31, 30, 30, 30, 30, 30, 30,29, 29, 29, 28, 27, 27, 27, 25, 24, 24, 24, 24, 24, 24, 24, 21,19, 19, 19, 19, 18, 17, 17, 16, 16, 16, 16, 16, 16, 15, 15, 15, 14,14,13, 13, 12, 12, 11, 10, 10, 10, 10, 10, 9, 9, 8, 8, 6, 6, 6, 5, 4, 4, 4, 3, 3, 3, 2, 2, 2, 2
                    }
                        )]
        public void ClimbingLeaderboardTest1(long[] scores, long[] alice, int[] expected)
        {
            int[] actual = ClimbingLeaderboard.climbingLeaderboard(scores, alice);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(ClimbingLeaderboardTestData))]
        public void ClimbingLeaderboardBinaryTest1(List<long> scores, long score, int expected)
        {
            int actual = ClimbingLeaderboard.FindIndexReverseBinarySearch(scores, score);

            Assert.Equal(expected, actual);
        }
    }
}
