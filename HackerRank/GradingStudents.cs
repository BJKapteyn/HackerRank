using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    public class GradingStudents
    {
        public static int GradeStudent(int grade)
        {
            if(grade >= 38 && !((grade + 3) % 5 == 0 || (grade + 4) % 5 == 0) && grade != 0)
            {
                while(grade % 5 != 0)
                {
                    grade++;
                }
            }
            return grade;
        }

        public static List<int> GradeAllStudents(List<int> grades)
        {
            for(int i = 0; i < grades.Count; i++)
            {
                grades[i] = GradeStudent(grades[i]);
            }
            return grades;
        }

        [Theory]
        [InlineData(37, 37)]
        [InlineData(38, 40)]
        [InlineData(42, 42)]
        [InlineData(78, 80)]
        [InlineData(61, 61)]
        public void GradeStudentTest(int test, int expected)
        {
            Assert.Equal(expected, GradeStudent(test));
        }

        [Fact]
        public void GradeAllStuentsTest()
        {
            List<int> test = new List<int> { 32, 34, 69, 82 };
            List<int> expected = new List<int> { 32, 34, 70, 82 };

            Assert.Equal(expected, GradeAllStudents(test));
        }
        [Fact]
        public void GradeAllStuentsTest2()
        {
            List<int> test = new List<int> {
                84, 94, 21, 0, 18, 100, 18, 62, 30, 61, 53, 0, 43, 2, 29, 53, 61, 40
            };
            List<int> expected = new List<int> {
                85, 95, 21, 0, 18, 100, 18, 62, 30, 61, 55, 0, 45, 2, 29, 55, 61, 40
            };


            Assert.Equal(expected, GradeAllStudents(test));
        }

    }
}
