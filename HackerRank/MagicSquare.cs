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
            for(int i = 0; i < s.Length; i++)
            {
                int horizontal = 0;
                for(int k = 0; k < s[i].Length; k++)
                {
                    int verticle = 0;
                    horizontal += s[i][k];
                }
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
