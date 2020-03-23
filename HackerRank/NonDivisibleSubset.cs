using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //https://www.hackerrank.com/challenges/non-divisible-subset/problem
    class NonDivisibleSubset
    {
        public static int nonDivisibleSubset(int divisor, List<int> nonDivisibleSubsetList)
        {
            int result = 0;
            List<int> remainders = findRemainders(nonDivisibleSubsetList, divisor);

            Dictionary<int, int> indexAndFrequency = new Dictionary<int, int>();

            
            return result;
        }

        public static List<int> findRemainders(List<int> list, int divisor)
        {
            
            return list;
        }
    }

    public class NonDivisableSubsetTest
    {
        [Theory] 
        [ClassData(typeof(NonDivisibleSubsetData))]
        public void Test1(int divisor, List<int> nonDivisibleSubsetList, int expected)
        {
            int actual = NonDivisibleSubset.nonDivisibleSubset(divisor, nonDivisibleSubsetList);

            Assert.Equal(expected, actual);
        }
    }

    public class NonDivisibleSubsetData : IEnumerable<object[]>
    {
        public static List<int> data1 = new List<int>() { 1, 7, 2, 4 };
        public static List<int> data2 = new List<int>() { 19, 10, 12, 10, 24, 25, 22 };
        private readonly List<object[]> Data = new List<object[]>()
        {
            new object[] { (int)3, data1,  (int) 3},
            new object[] { (int)4, data2,  (int) 3}
        };
        public IEnumerator<object[]> GetEnumerator() => Data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
