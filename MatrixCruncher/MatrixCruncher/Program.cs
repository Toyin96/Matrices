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

            var result = MatrixClient.CalculateDeterminant(4, matrix);
            Console.WriteLine(result);

            double[,] firstMatrix = { { 1, 2, 3 }, {4, 5, 6} };
            double[,] secondMatrix = { { 4, 2, 1 }, { 7, 5, 9 } };

            var res = MatrixClient.MultiplyMatrix(firstMatrix, secondMatrix);
            Console.WriteLine("The result of the multiplied matrices is {0}", res);
        }
    }
}
