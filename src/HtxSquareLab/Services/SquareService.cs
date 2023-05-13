using System;
namespace HtxSquareLab.Services
{
	public class SquareService
	{
		public int CalculateTotalSquares(int n)
		{
			if (n <= 0)
			{
				throw new ArgumentException("N must be greater than 0");
			}

			int totalSquares = 0;

            /*
				 The number of squares in a row is equal to n - i + 1,
				 where i is the current row number.The total count is calculated by multiplying
				 the number of squares in the row by itself and adding it to the running total.
			 */
            for (int i = 1; i <= n; i++)
			{
				int squaresInRow = n - i + 1;
				totalSquares += squaresInRow * squaresInRow; 
			}

			return totalSquares;
		}
	}
}

