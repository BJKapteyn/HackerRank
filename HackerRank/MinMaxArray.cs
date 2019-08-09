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
        public static int[] MinMax(int[] arr)
        {
            int[] result = new int[2];
            List<int> additions = ListOfPossibleSums(arr);
            result[0] = additions.Min();
            result[1] = additions.Max();
            return result;
        }
        public static List<int> ListOfPossibleSums(int[] arr)
        {
            List<int> sums = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
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
            int[] solution = { 10, 14 };
            int[] test = { 1, 2, 3, 4, 5 };

            Assert.Equal(solution, MinMax(test));
        }
        [Fact] 
        public void MinMaxTest2()
        {
            int[] solution = { 16, 24 };
            int[] test = { 1, 3, 5, 7, 9 };

            Assert.Equal(solution, MinMax(test));
        }
    }
}
