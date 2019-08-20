using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class MagicSquare
    {
        public static int formingMagicSquare(int[][] s)
        {
            int result = 0;
            int[][] copyArr = Copy(s);
            return result;
        }

        public static List<int> TotalsReduced(int[][] s)
        {
            List<int> results = new List<int>();
            int vertical = 0;
            for(int i = 0; i < s.Length; i++)
            {
                int horizontal = 0;
                for(int k = 0; k < s[i].Length; k++)
                {
                    vertical += s[k][i];
                    horizontal += s[i][k];
                }
                results.Add(vertical);
                results.Add(horizontal);
                vertical = 0;
                horizontal = 0;
            }

            return results.Distinct().ToList();
        }

        public static int[][] Copy(int[][] arr)
        {
            int[][] copy = new int[3][];

            for(int i = 0; i < arr.Length; i++)
            {
                int[] copyArr = new int[arr[i].Length];
                for(int k = 0; k < arr[i].Length; k++)
                {
                    copyArr[k] = arr[i][k];
                }
                copy[i] = copyArr;
            }

            return copy;
        }
    }

    public class MagicSquareTest
    {
        [Fact]
        public void MagicSquareTest1()
        {
            int[][] test = { new int[] { 8, 2, 3 }, new int[] { 9, 7, 3 }, new int[] { 8, 2, 4 } };
            List<int> actual = MagicSquare.TotalsReduced(test);
        }

        [Fact]
        public void CopyTest1()
        {
            int[][] expected = { new int[] { 8, 2, 3 }, new int[]{ 9, 7, 3 }, new int[]{ 8, 2, 4 } };
            int[][] actual = MagicSquare.Copy(expected);

            Assert.Equal(expected, actual);
        }
    }
}
