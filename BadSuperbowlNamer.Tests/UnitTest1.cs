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

        [Fact]
        public void Number45ShouldOutputXLV()
        {
            var number = 45;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("XLV", result);
        }

        [Fact]
        public void Number68ShouldOutputLXVIII()
        {
            var number = 68;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("LXVIII", result);
        }

        [Fact]
        public void Number83ShouldOutputLXXXIII()
        {
            var number = 83;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("LXXXIII", result);
        }

        [Fact]
        public void Number97ShouldOutputXCVII()
        {
            var number = 97;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("XCVII", result);
        }

        [Fact]
        public void Number99ShouldOutputXCIX()
        {
            var number = 99;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("XCIX", result);
        }

        [Fact]
        public void Number500ShouldOutputD()
        {
            var number = 500;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("D", result);
        }

        [Fact]
        public void Number501ShouldOutputDI()
        {
            var number = 501;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("DI", result);
        }

        [Fact]
        public void Number649ShouldOutputDCXLIX()
        {
            var number = 649;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("DCXLIX", result);
        }

        [Fact]
        public void Number798ShouldOutputDCCXCVIII()
        {
            var number = 798;
            var converter = new RomanNumeralConverter();

            var result = converter.ConvertNumber(number);

            Assert.Equal("DCCXCVIII", result);
        }
    }
}
