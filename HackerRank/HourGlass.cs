using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //calculate the values of an hourglass shape in a 6X6 2D array
    class HourGlass
    {
        public static int hourglassSum(int[][] arr)
        {
            int result = 0;
            List<int> results = new List<int>();

            for(int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    int total = arr[i][k] +
                                arr[i][k + 1] +
                                arr[i][k + 2] +
                                arr[i + 1][k + 1] +
                                arr[i + 2][k] +
                                arr[i + 2][k + 1] +
                                arr[i + 2][k + 2];
                    results.Add(total);
                }
            }
            result = results.Max();
            return result;
        }
    }

    public class HourGlassTest
    {

    }
}
