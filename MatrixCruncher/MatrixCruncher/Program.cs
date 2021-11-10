using MatrixCruncher.models;
using System;

namespace MatrixCruncher
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[4, 4] { {2, 6, 6, 2},
                                                  {2, 7, 3, 6},
                                                  {1, 5, 0, 1},
                                                  {3, 7, 0, 7} };

            var result = MatrixClient.Determinant(4, matrix);
            Console.WriteLine(result);
        }
    }
}
