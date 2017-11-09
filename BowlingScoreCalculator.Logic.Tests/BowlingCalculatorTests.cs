using System;
using Xunit;
using BowlingScoreCalculator.Logic;

namespace BowlingScoreCalculator.Logic.Test
{
    public class BowlingCalculatorTests
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [InlineData("9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||", 90)]
        [InlineData("5/|5/|5/|5/|5/|5/|5/|5/|5/|5/||5", 150)]
        [InlineData("X|7/|9-|X|-8|8/|-6|X|X|X||81", 167)]
        [InlineData("X|X|9/|X|-8|8/|-/|X|X|X||7-", 199)]
        public void CalculatorResultTest(string input, int result)
        {
            var bowlingCalculator = new BowlingCalculator();
            Assert.Equal(bowlingCalculator.Calculate(input), result);
        }
    }
}
