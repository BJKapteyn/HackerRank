using System;
using System.Collections;
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
        public static int pickingNumbers(List<int> integerArray)
        {
            int result = 0;
            List<int> usedNumbers = new List<int>();
            integerArray.Sort();

            for(int i = 0; i < integerArray.Count; i++)
            {
                int numOfIntegersWithinOne = 0;
                //skip the integer in the array if it has already been checked.
                if(usedNumbers.Contains(integerArray[i]))
                {
                    continue;
                }
                
                for (int j = 0; j < integerArray.Count; j++)
                {
                    //on first loop, check if there is a number one less than the current index in the array, 
                    //if not start at index one after the checked index.
                    if(j == 0)
                    {
                        if(i > 0)
                        {
                            if(integerArray.Contains(integerArray[j] - 1))
                            {
                                j = integerArray.IndexOf(integerArray[j] - 1);
                                //j = Array.IndexOf(integerArray, (integerArray[j] - 1));
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
        [ClassData(typeof(PickNumbersTestData))]
        public void PickingNumbersTest1(List<int> list, int expected)
        {
            int actual = PickingNumbers.pickingNumbers(list);

            Assert.Equal(expected, actual);
        }
    }

    public class PickNumbersTestData : IEnumerable<object[]>
    {
        public static List<int> data1 = new List<int> { 1, 1, 2, 2, 4, 4, 5, 5, 5 };
        public static List<int> data2 = new List<int> { 4, 6, 5, 3, 3, 1 };
        public static List<int> data3 = new List<int> { 1, 2, 2, 3, 1, 2 };
        private readonly List<object[]> Data = new List<object[]>()
        {
            new object[] {data1, 5},
            new object[] {data2, 3},
            new object[] {data3, 5}
        };

        public IEnumerator<object[]> GetEnumerator() => Data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
