using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //take an array and move the elements 'rotate' indexes to the left
    class RotateArray
    {
        public static int[] rotateArray(int[] arr, int rotate)
        {
            int[] result = new int[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                int rotatedIndex;
                if((i - rotate) < 0)
                {
                    //if the index after the rotate operation is less than zero, continue the rotation from the end of the list
                    rotatedIndex = arr.Length - Math.Abs(i - rotate);
                }
                else
                {
                    rotatedIndex = i - rotate;
                }
                result[rotatedIndex] = arr[i];
            }

            return result;
        }
    }

    public class RotateArrayTest
    {
        [Theory]
        [InlineData(new int[] { 5, 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5 }, 4)]
        public void rotateArrayTest1(int[] expected, int[] test, int rotate)
        {
            int[] actual = RotateArray.rotateArray(test, rotate);

            Assert.Equal(expected, actual);
        }
    }
}
