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
            if(grade >= 40)
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
            foreach(int grade in grades)
            {
                GradeStudent(grade);
            }
            return grades;
        }

        [Theory]
        [InlineData(40, 40)]
        [InlineData(38, 38)]
        [InlineData(44, 45)]
        [InlineData(78, 80)]
        public void GradeStudentTest(int test, int expected)
        {
            Assert.Equal(expected, GradeStudent(test));
        }

    }
}
