using System;
using HtxSquareLab.Services;

namespace HtxLabs.Tests
{
	public class SquareLabTest
	{
		[Fact]
		public void TestCalculateTotalSquares_NEquals2_Returns5()
		{
			// Arrange
			var squareService = new SquareService();
			int n = 2;
			int expected = 5;

			// Act
			var sut = squareService.CalculateTotalSquares(n);

			// Assert
			Assert.Equal(expected, sut);
		}

		[Fact]
		public void TestCalculateTotalSquares_NEquals5_Returns55()
		{
            // Arrange
            var squareService = new SquareService();
            int n = 5;
            int expected = 55;

            // Act
            var sut = squareService.CalculateTotalSquares(n);

            // Assert
            Assert.Equal(expected, sut);
        }
		[Theory]
		[InlineData(-1)]
		[InlineData(0)]
		public void TestcalculateTotalSquares_NEqualsNegativeNumber_ThrowsException(int n)
		{
            // Arrange
            var squareService = new SquareService();

			// Act and Assert
			Assert.Throws<ArgumentException>(() => squareService.CalculateTotalSquares(n));
        }
    }
}

