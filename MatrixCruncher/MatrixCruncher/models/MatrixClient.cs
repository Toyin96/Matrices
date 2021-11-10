using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixCruncher.models
{
    class MatrixClient
    {
        public static double CalculateDeterminant(int n, double[,] Mat)
        {
            double determinantValue = 0;
            int k, i, j, subi, subj;
            double[,] SUBMat = new double[n, n];

            if (n == 2)
            {
                return ((Mat[0, 0] * Mat[1, 1]) - (Mat[1, 0] * Mat[0, 1]));
            }

            else
            {
                for (k = 0; k < n; k++)
                {
                    subi = 0;
                    for (i = 1; i < n; i++)
                    {
                        subj = 0;
                        for (j = 0; j < n; j++)
                        {
                            if (j == k)
                            {
                                continue;
                            }
                            SUBMat[subi, subj] = Mat[i, j];
                            subj++;
                        }
                        subi++;
                    }
                    determinantValue = determinantValue + (Math.Pow(-1, k) * Mat[0, k] * Determinant(n - 1, SUBMat));
                }
            }
            return determinantValue;
        }

        public double[,] MultiplyMatrix(double[,] A, double[,] B)
        {
            int rA = A.GetLength(0);
            int cA = A.GetLength(1);
            int rB = B.GetLength(0);
            int cB = B.GetLength(1);
            double temp = 0;
            double[,] newMatrix = new double[rA, cB];
            if (cA != rB)
            {
                Console.WriteLine("matrik can't be multiplied !!");
            }
            else
            {
                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < cA; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        newMatrix[i, j] = temp;
                    }
                }
                return newMatrix;
            }
        }


    }
}
