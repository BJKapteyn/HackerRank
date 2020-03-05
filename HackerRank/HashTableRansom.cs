using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //Harold is a kidnapper who wrote a ransom note, but now he is worried it will be traced back to him through his handwriting.He found a magazine and wants to
    //know if he can cut out whole words from it and use them to create an untraceable replica of his ransom note.The words in his note are case-sensitive and he 
    //must use only whole words available in the magazine. He cannot use substrings or concatenation to create the words he needs.
    
    //note the challenge calls for hash tables but that seems unnecessary
    public class HashTableRansom
    {
        public static bool CanMakeRansom(string[] magazine, string[] ransomNote)
        {
            bool result = false;
            int ransomIndex = 0;
            int magIndex = 0;

            Array.Sort(magazine);
            List<string> mag = magazine.ToList();
            Array.Sort(ransomNote);
            List<string> ransomN = ransomNote.ToList();


            while(magIndex < mag.Count)
            {
                if (ransomN[ransomIndex] == mag[magIndex])
                {
                    if(ransomIndex < ransomN.Count)
                    {
                        ransomIndex++;
                        if (ransomIndex == ransomN.Count)
                        {
                            return true;
                        }
                    }
                   
                }
                magIndex++;
            }

            //foreach(string word in ransomNote)
            //{
            //    if (!(mag.Exists(x => x == word)))
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        mag.Remove(word);
            //    }
            //}

            return result;
        }

        public static void checkMagazine(string[] magazine, string[] ransomNote)
        {
            if(CanMakeRansom(magazine, ransomNote))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    public class HashTableRansomTest
    {
        [Theory]
        [InlineData(new string[] { "two", "times", "three", "is", "not", "four" }, new string[] { "two", "times", "three", "is", "four" }, true)]
        [InlineData(new string[] { "Two", "times", "three", "is", "not", "four" }, new string[] { "two", "times", "three", "is", "four" }, false)]
        [InlineData(new string[] { "two", "times", "three", "is", "not", "four" }, new string[] { "two", "times", "two", "is", "four" }, false)]

        public void HashTableTest1(string[] magazine, string[] ransomNote, bool expected)
        {
            bool actual = HashTableRansom.CanMakeRansom(magazine, ransomNote);

            Assert.Equal(expected, actual);
        }

    }
}
