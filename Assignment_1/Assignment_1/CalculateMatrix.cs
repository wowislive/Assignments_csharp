namespace Assignment_1
{
    class CalculateMatrix
    {
        public static int[,] SumMatrix(int[,] matrixOne, int[,] matrixTwo) {
            int row = matrixOne.GetLength(0);
            int col = matrixOne.GetLength(1);

            int[,] resultMatrix = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < matrixOne.GetLength(1); j++)
                    resultMatrix[i, j] = matrixOne[i, j] + matrixTwo[i, j];

            return resultMatrix;
        }

        public static int[,] SubMatrix(int[,] matrixOne, int[,] matrixTwo) {
            int row = matrixOne.GetLength(0);
            int col = matrixOne.GetLength(1);

            int[,] resultMatrix = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < matrixOne.GetLength(1); j++)
                    resultMatrix[i, j] = matrixOne[i, j] - matrixTwo[i, j];

            return resultMatrix;
        }

        public static int[,] MultMatrix(int[,] matrixOne, int[,] matrixTwo) {
            int row1 = matrixOne.GetLength(0);
            int col1 = matrixOne.GetLength(1);
            // int row2 = matrixTwo.GetLength(0);
            int col2 = matrixTwo.GetLength(1);

            int[,] resultMatrix = new int[row1, col2];

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < col1; k++)
                    {
                        sum += matrixOne[i, k] * matrixTwo[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }

            return resultMatrix;
        }
    }
}
