using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class SavePrisoner
    {
        //A jail has a number of prisoners and a number of treats to pass out to them.Their jailer decides
        //    the fairest way to divide the treats is to seat the prisoners around a circular table in
        //    sequentially numbered chairs.A chair number will be drawn from a hat.Beginning with the
        //    prisoner in that chair, one candy will be handed to each prisoner sequentially around the
        //    table until all have been distributed.

        //    The jailer is playing a little joke, though.The last piece of candy looks like all the others,
        //    but it tastes awful. Determine the chair number occupied by the prisoner who will receive that
        //    candy.

        //    For example, there are 4 prisoners and 6 pieces of candy.The prisoners arrange themselves in seats numbered to.Let's
        //    suppose two is drawn from the hat. Prisoners receive candy at 2, 3, 4, 1, 2, 3 positions.The prisoner to be
        //    warned sits in chair number 3. 
        public static int saveThePrisoner(int n, int m, int s)
        {
            if(s + m <= n)
            {
                return s + m - 1;
            }
            int result = (s - 1 + m) % n;

            if(result == 0)
            {
                return n;
            }
            else
            {
                return result;
            }

        }
    }

    public class SavePrisonerTest
    {
        [Theory]
        [InlineData(5, 2, 1, 2)]
        [InlineData(7, 19, 2, 6)]
        [InlineData(3, 7, 3, 3)]
        public void SaveThePrisonerTest1(int n, int m, int s, int expected)
        {
            int actual = SavePrisoner.saveThePrisoner(n, m, s);

            Assert.Equal(expected, actual);
        }

    }
}
