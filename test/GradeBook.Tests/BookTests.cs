using System;
using System.Threading;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesGrades()
        {
            
            //  arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //  act
            var result = book.GetStats();

            //  assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void BookAddsGrades()
        {
            var book = new Book("");
            book.AddGrade(90.1);
            book.AddGrade(-1);
            book.AddGrade(100.1);

            var result = book.GetStats();

            Assert.Equal(result.High, result.Low);
        }
    }
}
