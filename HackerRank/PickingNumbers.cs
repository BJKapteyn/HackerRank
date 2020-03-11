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
            List<int> usedNumbers = new List<int>();
            Array.Sort(integerArray);

            for(int i = 0; i < integerArray.Length; i++)
            {
                int numOfIntegersWithinOne = 0;
                //skip the number if it has already been checked.
                if(usedNumbers.Contains(integerArray[i]))
                {
                    continue;
                }
                
                for (int j = 0; j < integerArray.Length; j++)
                {
                    //on first loop, check if there is a number one less than the current index in the array, 
                    //if not start at index one after the current index.
                    if(j == 0)
                    {
                        if(i > 0)
                        {
                            if(integerArray.Contains(integerArray[j] - 1))
                            {
                                j = Array.IndexOf(integerArray, (integerArray[j] - 1));
                                continue;
                            }
                            else
                            {
                                j = i;
                            }
                        }
                    }

                    if(i == j)
                    {
                        continue;
                    }
                    else if(Math.Abs(integerArray[i] - integerArray[j]) > 1)
                    {
                        break;
                    }
                    else
                    {
                        numOfIntegersWithinOne++;
                    }
                }

                if(numOfIntegersWithinOne > result)
                {
                    result = numOfIntegersWithinOne;
                }

                usedNumbers.Add(integerArray[i]);
            }

            //add one to the result to include the index that was tested.
            result += 1;

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
