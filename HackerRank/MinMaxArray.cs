using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //finds the min and max of the sum of 4 out of 5 of the array
    public class MinMaxArray
    {
        public static long[] MinMax(int[] arr)
        {
            long[] result = new long[2];
            List<long> additions = ListOfPossibleSums(arr);
            result[0] = additions.Min();
            result[1] = additions.Max();
            return result;
        }
        public static List<long> ListOfPossibleSums(int[] arr)
        {
            List<long> sums = new List<long>();
            for (int i = 0; i < arr.Length; i++)
            {
                long sum = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    if (k == i)
                    {
                        continue;
                    }
                    sum += arr[k];

                }
                sums.Add(sum);
            }
            return sums;
        }

        [Fact]
        public void MinMaxTest()
        {
            long[] solution = { 10, 14 };
            int[] test = { 1, 2, 3, 4, 5 };

            Assert.Equal(solution, MinMax(test));
        }
        [Fact]
        public void MinMaxTest2()
        {
            long[] solution = { 16, 24 };
            int[] test = { 1, 3, 5, 7, 9 };

            Assert.Equal(solution, MinMax(test));
        }

        [Fact]
        public void LongTest()
        {
            long[] solution = { 1659655705, 2484892405 };
            int[] test = { 426980153, 354802167, 142980735, 968217435, 734892650 };

            Assert.Equal(solution, MinMax(test));
        }
    }
}
