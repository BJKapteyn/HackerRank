using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int> {
                84, 94, 21, 0, 18, 100, 18, 62, 30, 61, 53, 0, 43, 2, 29, 53, 61, 40
            };
            List<int> expected = new List<int> {
                85, 95, 21, 0, 18, 100, 18, 62, 30, 61, 55, 0, 45, 2, 29, 55, 61, 40
            };
            Console.WriteLine("\nTest numbers:");
            foreach (int g in test)
            {
                Console.Write(g + " ");
            }
            List<int> grade = GradingStudents.GradeAllStudents(test);
            Console.WriteLine("\nmine");
            foreach(int g in grade)
            {
                Console.Write(g + " ");
            }
            Console.WriteLine("\nExpected");
            foreach (int g in expected)
            {
                Console.Write(g + " ");
            }
            Console.ReadKey();
        }
        
    }
    
}
