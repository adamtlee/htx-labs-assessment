using HtxSquareLab.Services;

namespace HtxSquareLab;
class Program
{
    static void Main(string[] args)
    {
        var squareService = new SquareService();

        var result = squareService.CalculateTotalSquares(2);

        Console.WriteLine(result);
    }
}

