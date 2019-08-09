using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    //finds the min and max of the sum of 4 out of 5 of the array
    class MinMaxArray
    {
        public static int[] MinMax(int[] arr)
        {
            int[] result = new int[2];
            List<int> additions = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                sum += arr[i];
                for(int k = 0; k < arr.Length; k++)
                {
                    if(k == i)
                    {
                        continue;
                    }
                    sum += arr[k];

                }
                additions.Add(sum);
            }
            result[0] = additions.Max();
            result[1] = additions.Min();
            return result;
        }
    }
}
