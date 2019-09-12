using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    //You have been asked to help study the population of birds migrating across the continent.Each type 
    //    of bird you are interested in will be identified by an integer value.Each time a particular 
    //    kind of bird is spotted, its id number will be added to your array of sightings.You would like 
    //    to be able to find out which type of bird is most common given a list of sightings.Your task 
    //    is to print the type number of that bird and if two or more types of birds are equally common,
    //    choose the type with the smallest ID number.
    class MigratoryBirds
    {
        public static int MigBirds(List<int> birds)
        {
            int result = 0;
            int[] migBirds = { 1, 2, 3, 4, 5 };
            int numOfBirds = 0;
            int mostBirds = 0;
            int mostBirdsIndex = 0;

            for (int i = 0; i < migBirds.Length; i++)
            {
                for (int k = 0; k < birds.Count; k++)
                {
                    if(migBirds[i] == birds[k])
                    {
                        numOfBirds++;
                    }
                }
                if(numOfBirds > mostBirds)
                {
                    mostBirds = numOfBirds;
                    mostBirdsIndex = i;
                }
                numOfBirds = 0;
            }
            result = migBirds[mostBirdsIndex];

            return result;
        }
    }

    public class MigratoryBirdsTest
    {
        [Fact]
        public static void MigTest1()
        {
            List<int> test = new List<int>() { 1, 4, 4, 4, 5, 3 };
            int expected = 4;
            int actual = MigratoryBirds.MigBirds(test);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public static void MigTest2()
        {
            List<int> test = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            int expected = 3;
            int actual = MigratoryBirds.MigBirds(test);

            Assert.Equal(expected, actual);
        }
    }
}
