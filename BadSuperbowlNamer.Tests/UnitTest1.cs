using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class BadSuperbowlNamerTests
    {
        [Fact]
        public void Number1ShouldOutputI()
        {
            //Arrange
            var number = 1;
            var converter = new RomanNumeralConverter();

            //Act
            var result = converter.ConvertNumber(number);

            //Assert
            Assert.Equal("I", result);
        }
    }
}
