using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact] // attribute attached to method to tell Xunit to execute test
        public void Test1()
        {
           // arrange section 
           var x = 5;
           var y = 2;
           var expected = 1000;

           // act section 
           var actual = x * y;
                     
           // assert section
           Assert.Equal(expected, actual);
        }
    }
}
