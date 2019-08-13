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
            string result = "";
            Kangaroo k1 = new Kangaroo(x1, v1);
            Kangaroo k2 = new Kangaroo(x2, v2);
            return result;
        }
    }

    public class Kangaroo
    {
        public int Start { get; set; }
        public int Jump { get; }
        public Kangaroo(int start, int jump)
        {
            Start = start;
            Jump = jump;
        }
    }

    public class KangarooTest
    {
        [Fact]
        public void KangarooTest1()
        {
            string test = KangarooJump.kangaroo(0, 2, 5, 3);
            string expected = "YES";

            Assert.Equal(expected, test);
        }
    }
}
