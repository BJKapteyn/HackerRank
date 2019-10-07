using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class BoneAppetit
    {
        //Anna and Brian are sharing a meal at a restuarant and they agree to split the bill 
        //equally.Brian wants to order something that Anna is allergic to though, and they agree 
        //that Anna won't pay for that item. Brian gets the check and calculates Anna's 
        //portion. You must determine if his calculation is correct.
        //bill is list of items bought. k is the index for the item anna doesn't eat. b is
        //the amount brian gives anna. if brian gives her the correct change, print 
        //"bon appetit" otherwise print the amount brian still owes her
        public static string bonAppetitString(List<int> bill, int k, int b)
        {
            string result = "";

            return result;
        }
        public static void bonAppetit(List<int> bill, int k, int b)
        {


        }
    }
    public class BoneAppetitTestData : IEnumerable<object[]>
    {
        private static List<int> testData1 = new List<int> { 3, 10, 2, 9 };
        private static List<int> testData2 = new List<int> { 4, 2, 6 };
        private static List<int> testData3 = new List<int> { 2, 4, 6, 6 };

        private readonly List<object[]> Data = new List<object[]>()
        {
            new object[] { testData1, 1, 12, "5" },
            new object[] { testData2, 2, 6, "3"},
            new object[] {testData3, 3, 6, "Bon Appetit"}
        };

        public IEnumerator<object[]> GetEnumerator() => Data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class BonAppetitTest
    {
        [Theory]
        [ClassData(typeof(BoneAppetitTestData))]
        public void BonAppetitTest1(List<int> bill, int indexSkipped, int payed, string expected)
        {
            string actual = BoneAppetit.bonAppetitString(bill, indexSkipped, payed);

            Assert.Equal(expected, actual);
        }
    }
}
