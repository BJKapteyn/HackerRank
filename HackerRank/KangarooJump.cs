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
        public virtual string kangaroo(int x1, int v1, int x2, int v2)
        {
            string result = "YES";
            Kangaroo k1 = new Kangaroo(x1, v1);
            Kangaroo k2 = new Kangaroo(x2, v2);
            int distanceLast = int.MaxValue;
            int distanceThis = 0;

            while(k1.Position != k2.Position)
            {
                distanceThis = Math.Abs(k1.Position - k2.Position);
                if(distanceThis >= distanceLast)
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

    class KrooJump : KangarooJump
    {
        public override string kangaroo(int x1, int v1, int x2, int v2)
        {
            int lastJump = int.MaxValue;
            while(x1 != x2)
            {
                int thisJump = Math.Abs((x1 += v1) - (x2 += v2));
                if(thisJump >= lastJump)
                {
                    return "NO";
                }
                lastJump = thisJump;
            }
            return "YES";
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
        [InlineData(0, 2, 5, 3, "NO")]
        [InlineData(0, 3, 4, 2, "YES")]
        public void KangarooTest1(int x1, int v1, int x2, int v2, string expected)
        {
            KangarooJump kroo = new KangarooJump();
            string test = kroo.kangaroo(x1, v1, x2, v2);

            Assert.Equal(expected, test);
        }

        [Fact]
        public void KrooTest1()
        {
            KrooJump kjump = new KrooJump();

            Assert.Equal("NO", kjump.kangaroo(0, 2, 5, 3));
        }
    }
}
