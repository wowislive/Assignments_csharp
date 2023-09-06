using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //It is important to initialize "rand" at this point and then pass it as an argument further
            //If I initialize it directly in the Matrix class, I get the generation of identical matrices
            Random rand = new Random();

            //Generating the number of rows and columns for addition and subtraction operations
            //The number of rows and columns should be the same for both matrices
            int rowNumb1 = rand.Next(2, 10);
            int colNumb1 = rand.Next(2, 10);
            int rowNumb2 = rowNumb1;
            int colNumb2 = colNumb1;

            int[,] matrix1 = Matrix.CreateMatrix(rowNumb1, colNumb1, rand);
            int[,] matrix2 = Matrix.CreateMatrix(rowNumb2, colNumb2, rand);

            Matrix.PrintMatrix("This is matrix1:", matrix1);
            Matrix.PrintMatrix("This is matrix2:", matrix2);

            //performing the addition operation
            int[,] sumResult = CalculateMatrix.SumMatrix(matrix1, matrix2);

            Matrix.PrintMatrix("This is result of matrix SUM:", sumResult);

            //performing the subtraction operation
            int[,] subResult = CalculateMatrix.SubMatrix(matrix1, matrix2);

            Matrix.PrintMatrix("This is result of matrix SUB:", subResult);

            //To multiply matrices 3 and 4, the number of columns in matrix 3 must be equal to the number of rows in matrix 4
            int rowNumb3 = rand.Next(2, 10);
            int rowNumb4 = rand.Next(2, 10);
            int colNumb3 = rowNumb4;
            int colNumb4 = rand.Next(2, 10);

            int[,] matrix3 = Matrix.CreateMatrix(rowNumb3, colNumb3, rand);
            int[,] matrix4 = Matrix.CreateMatrix(rowNumb4, colNumb4, rand);

            Matrix.PrintMatrix("This is matrix3:", matrix3);
            Matrix.PrintMatrix("This is matrix4:", matrix4);

            //performing the multiplication operation
            int[,] multResult = CalculateMatrix.MultMatrix(matrix3, matrix4);

            Matrix.PrintMatrix("This is result of matrix MULT:", multResult);
        }
    }
}
