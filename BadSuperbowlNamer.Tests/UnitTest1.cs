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

        [Fact]
        public void Number5ShouldOutputV()
        {
            var number = 5;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("V", result);


        }

        [Fact]
        public void Number9ShouldOutputIX()
        {
            var number = 9;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("IX", result);
        }

        [Fact]
        public void Number12ShouldOutputXII()
        {
            var number = 12;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("XII", result);
        }

        [Fact]
        public void Number16ShouldOutputXVI()
        {
            var number = 16;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("XVI", result);
        }

        [Fact]
        public void Number29ShouldOutputXXIX()
        {
            var number = 29;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("XXIX", result);
        }

        [Fact]
        public void Number44ShouldOutputXLIV()
        {
            var number = 44;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("XLIV", result);
        }
    }
}
