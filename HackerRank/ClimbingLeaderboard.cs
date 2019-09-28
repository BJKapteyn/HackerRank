using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class ClimbingLeaderboard
    {
    }
    class Player
    {
        public string Name { get; set; } = "OtherPlayer";
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public Player(int score)
        {
            Score = score;
        }
    }
}
