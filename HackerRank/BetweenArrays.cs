using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class BetweenArrays
    {
        public static int GetTotalX(List<int> arr1, List<int> arr2)
        {
            //find all of the numbers that the integers of the first array are a factor of and also are a factor 
            //of all in the second array
            int result = 0;
            int low = arr1.Max();
            int high = arr2.Min();

            for (int i = low; i <= high; i++)
            {
                for (int j = 0; j < arr1.Count; j++)
                {
                    if (j == arr1.Count - 1 && i % arr1[j] == 0) 
                    {
                        for(int k = 0; k < arr2.Count; k++)
                        {
                            if(k == arr2.Count - 1 && arr2[k] % i == 0)
                            {
                                result++;
                            }
                            if(arr2[k] % i != 0)
                            {
                                break;
                            }
                        }
                    }
                    if(i % arr1[j] != 0)
                    {
                        break;
                    }
                    
                }
            }

            return result;
        }
    }

    public class BetweenArraysTest
    {
        [Fact]
        public void BetweenTest1()
        {
            int expected = 3;
            List<int> a = new List<int> { 2, 4 };
            List<int> b = new List<int> { 16, 32, 96 };
            int actual = BetweenArrays.GetTotalX(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BetweenTest2()
        {
            int expected = 2;
            List<int> a = new List<int> { 2, 6 };
            List<int> b = new List<int> { 24, 36 };
            int actual = BetweenArrays.GetTotalX(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
