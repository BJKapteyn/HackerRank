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
        public static int GetTotalX(List<int> a, List<int> b)
        {
            //find all of the numbers that the integers of the first array are a factor of and also are a factor 
            //of all in the second array
            int result = 0;
            int low = a.Max();
            int high = b.Min();

            for (int i = low; i <= high; i++)
            {
                for (int j = 0; j < a.Count; j++)
                {
                    if (j == a.Count - 1 && i % a[j] == 0) 
                    {
                        for(int k = 0; k < b.Count; k++)
                        {
                            if(k == b.Count - 1 && b[k] % i == 0)
                            {
                                result++;
                            }
                            if(b[k] % i != 0)
                            {
                                break;
                            }
                        }
                    }
                    if(i % a[j] != 0)
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
