using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //https://www.hackerrank.com/challenges/picking-numbers/problem
    //Given an array of integers, find and print the maximum number of integers you can select from the array such that the 
    //absolute difference between any two of the chosen integers is less than or equal to 1
    class PickingNumbers
    {
        public static int pickingNumbers(int[] integerArray)
        {
            int result = 0;

            Array.Sort(integerArray);



            return result;
        }
    }

    public class PickingNumbersTest
    {
        [Theory] 
        [InlineData(new int[] { 1, 1, 2, 2, 4, 4, 5, 5, 5 }, 5)]
        [InlineData(new int[] { 1, 2, 2, 3, 1, 2 }, 5)]
        public void PickingNumbersTest1(int[] arr, int expected)
        {
            int actual = PickingNumbers.pickingNumbers(arr);

            Assert.Equal(expected, actual);
        }
    }

}
