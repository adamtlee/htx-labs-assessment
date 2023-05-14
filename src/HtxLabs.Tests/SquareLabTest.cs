using System;
using HtxSquareLab.Services;

namespace HtxLabs.Tests
{
	public class SquareLabTest
	{
		[Theory]
		[InlineData(2,5)]
		[InlineData(5, 55)]
		public void TestCalculateTotalSquares_NEqualsPositive_ReturnsResult(int n, int expected)
		{
			// Arrange
			var squareService = new SquareService();

			// Act
			var sut = squareService.CalculateTotalSquares(n);

			// Assert
			Assert.Equal(expected, sut);
		}

		[Theory]
		[InlineData(-1)]
		[InlineData(0)]
		public void TestcalculateTotalSquares_NEqualsNegativeNumberOrZero_ThrowsException(int n)
		{
            // Arrange
            var squareService = new SquareService();

			// Act and Assert
			Assert.Throws<ArgumentException>(() => squareService.CalculateTotalSquares(n));
        }
    }
}

