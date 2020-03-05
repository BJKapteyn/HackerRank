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
    class HashTableRansom
    {

    }

    public class HashTableRansomTest
    {
        [Theory]
        [InlineData(new string[] { "two", "times", "three", "is", "not", "four" }, new string[] { "two", "times", "three", "is", "four" })]
        public void HashTableTest1(string[] magazine, string[] ransomNote)
        {

        }

    }
}
