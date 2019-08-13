using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class KangarooJump
    {
        //Two kangaroos have a starting position and a jump distance, see if they can land on the same spot at the same time.
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string result = "Yes";
            Kangaroo k1 = new Kangaroo(x1, v1);
            Kangaroo k2 = new Kangaroo(x2, v2);
            int distanceLast = 0;
            int distanceThis = 0;

            while(k1.Position != k2.Position)
            {
                distanceThis = Math.Abs(k1.Position - k2.Position);
                if(distanceThis <= distanceLast)
                {
                    return "NO";
                }
                distanceLast = distanceThis;
                k1.Jump();
                k2.Jump();
            }

            return result;
        }
    }

    public class Kangaroo
    {
        public int Position { get; set; }
        public int JumpDistance { get; }
        public void Jump()
        {
            this.Position += JumpDistance;
        }
        public Kangaroo(int position, int jumpD)
        {
            Position = position;
            JumpDistance = jumpD;
        }
    }

    public class KangarooTest
    {
        [Theory]
        [InlineData(0, 2, 5, 3)]
        [InlineData(0, 3, 4, 2)]
        public void KangarooTest1(int x1, int v1, int x2, int v2)
        {
            string test = KangarooJump.kangaroo(x1, v1, x2, v2);
            string expected = "NO";

            Assert.Equal(expected, test);
        }
    }
}
