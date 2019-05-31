using System;
using Xunit;

namespace Gradebook.Tests
{
    public class UnitTest1
    {

        //fact is equivalent to @Test
        [Fact]
        public void Test1()
        {
             var book = new Book("");

            book.AddGrade(89.1);
            book.AddGrade(75.9);
            book.AddGrade(65.3);
            book.AddGrade(40.6);
            book.AddGrade(95);

            var results =  book.GetStats();

            Assert.Equal(95,results.High);
            Assert.Equal(40.6,results.Low);
            Assert.Equal(73.18,results.Average,2);// check to the second precision decimal
            

        }
    }
}
