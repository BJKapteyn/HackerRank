using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class SparseArrays
    {
        //There is a collection of input strings and a collection of query strings.For each query string, determine 
        //    how many times it occurs in the list of input strings.

        public static int[] sparseArrays (string[] arr, string[] queryArr)
        {
            int[] result = new int[queryArr.Length];
            
            for(int i = 0; i < queryArr.Length; i++)
            {
                int count = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    if(queryArr[i] == arr[k])
                    {
                        count++;
                    }
                }

                result[i] = count;
            }

            return result;
        }

       
    }

    public class SparseArraysTest
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 0}, 
                    new string[] { "aba", "baba", "aba", "xzxb" },
                    new string[] { "aba", "xzxb", "ab" })]
        public void sparseArraysTest1(int[] expected, string[] test, string[] queryArr)
        {
            int[] actual = SparseArrays.sparseArrays(test, queryArr);

            Assert.Equal(expected, actual);
        }
    }
}
