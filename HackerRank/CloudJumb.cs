using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //For each game, Emma will get an array of clouds numbered 0 if they are safe or 1 if they must be avoided.For example, [0, 1, 0, 0, 0, 1, 0] indexed from 0 to 6. 
    //    The number on each cloud is its index in the list so she must avoid the clouds at indexes 1 and 5. She could follow the following two
    //    paths: 0 > 2 > 4 > 6 or 0, 2, 3, 4, 6. The first path takes jumps while the second takes.
    class CloudJumb
    {
        public static int CloudJump(int[] clouds)
        {
            int jumps = 0;
            
            for(int i = 0; i < clouds.Length;)
            {
                int firstCloud = i + 1;
                int secondCloud = i + 2;
                if (secondCloud >= clouds.Length - 1 || firstCloud == clouds.Length - 1) 
                {
                    jumps++;
                    break;
                }
                else if(clouds[secondCloud] ==  0)
                {
                    i = secondCloud;
                }
                else
                {
                    i = firstCloud;
                }
                jumps++;
            }
            return jumps;
        }
    }

    public class CloudJumpTest
    {
        [Theory]
        [InlineData(new int[] { 0, 0, 1, 0, 0, 0, 1, 0}, 4)]
        [InlineData(new int[] { 0, 0, 0, 0, 1, 0}, 3)]
        public void CloudJumpTest1(int[] testData, int expected)
        {
            int actual = CloudJumb.CloudJump(testData);

            Assert.Equal(expected, actual);
        }
    }
}
