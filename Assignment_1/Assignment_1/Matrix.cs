using System;

namespace Assignment_1
{
    class Matrix
    {
        public static int[,] CreateMatrix(int row, int col, Random rand) {

            int[,] newMatrix = new int[row, col];

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    newMatrix[i, j] = rand.Next(1, 100);

            return newMatrix;
        }
    }
}
