using FluentAssertions;
using JorJika.Helpers;
using System;
using Xunit;

namespace JorJika.Helpers.Tests
{
    public class NumberToWordUnitTests
    {
        [Fact]
        public void NumberToWord_function_should_return_1_in_georgian()
        {
            NumberHelper.NumberToWord(1).Should().Be("ერთი");
        }

        [Fact]
        public void NumberToWord_function_should_return_2_in_georgian()
        {
            NumberHelper.NumberToWord(2).Should().Be("ორი");
        }

        [Fact]
        public void NumberToWord_function_should_return_10_in_georgian()
        {
            NumberHelper.NumberToWord(10).Should().Be("ათი");
        }

        [Fact]
        public void NumberToWord_function_should_return_100_in_georgian()
        {
            NumberHelper.NumberToWord(100).Should().Be("ასი");
        }

        [Fact]
        public void NumberToWord_function_should_return_225_in_georgian()
        {
            NumberHelper.NumberToWord(225).Should().Be("ორას ოცდახუთი");
        }

        [Fact]
        public void NumberToWord_function_should_return_1000_in_georgian()
        {
            NumberHelper.NumberToWord(1000).Should().Be("ათასი");
        }

        [Fact]
        public void NumberToWord_function_should_return_1692_in_georgian()
        {
            NumberHelper.NumberToWord(1692).Should().Be("ათას ექვსას ოთხმოცდათორმეტი");
        }

        [Fact]
        public void NumberToWord_function_should_return_18020_in_georgian()
        {
            NumberHelper.NumberToWord(18020).Should().Be("თვრამეტი ათას ოცი");
        }

        [Fact]
        public void NumberToWord_function_should_return_1202039_in_georgian()
        {
            NumberHelper.NumberToWord(1202039).Should().Be("მილიონ ორას ორი ათას ოცდაცხრამეტი");
        }

        [Fact]
        public void NumberToWord_function_should_return_2202039_in_georgian()
        {
            NumberHelper.NumberToWord(2202039).Should().Be("ორი მილიონ ორას ორი ათას ოცდაცხრამეტი");
        }

        [Fact]
        public void NumberToWord_function_should_return_39202040_in_georgian()
        {
            NumberHelper.NumberToWord(39202040).Should().Be("ოცდაცხრამეტი მილიონ ორას ორი ათას ორმოცი");
        }

        [Fact]
        public void NumberToWord_function_should_return_39203000_in_georgian()
        {
            NumberHelper.NumberToWord(39203000).Should().Be("ოცდაცხრამეტი მილიონ ორას სამი ათასი");
        }

        [Fact]
        public void NumberToWord_function_should_return_200000000_in_georgian()
        {
            NumberHelper.NumberToWord(200000000).Should().Be("ორასი მილიონი");
        }

        [Fact]
        public void NumberToWord_function_should_return_200300000_in_georgian()
        {
            NumberHelper.NumberToWord(200300000).Should().Be("ორასი მილიონ სამასი ათასი");
        }

        [Fact]
        public void NumberToWord_function_should_return_900300000_in_georgian()
        {
            NumberHelper.NumberToWord(900300000).Should().Be("ცხრაასი მილიონ სამასი ათასი");
        }
    }
}
