using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //section 1: arrange
            var book = new Book("");
            book.addGrade(71.1);
             book.addGrade(81.1);
              book.addGrade(91.1);
            
            //section 2: act
          // var result= book.GetStatistics();

             //section 3: assert
        Assert.Equal(85.6,result.Average,1);
        Assert.Equal(90.5,result.High,1);
        Assert.Equal(77.3,result.Low,1);
        }
    }
}
