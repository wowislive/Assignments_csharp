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

            //performing the addition operation
            int[,] sumResult = CalculateMatrix.SumMatrix(matrix1, matrix2);

            Console.WriteLine("This is result of matrix SUM:");
            for (int i = 0; i < rowNumb1; i++)
            {
                for (int j = 0; j < colNumb1; j++)
                    Console.Write("{0,5}", sumResult[i, j]);

                Console.WriteLine();
            }

            //performing the subtraction operation
            int[,] subResult = CalculateMatrix.SubMatrix(matrix1, matrix2);

            Console.WriteLine("This is result of matrix SUB:");
            for (int i = 0; i < rowNumb1; i++)
            {
                for (int j = 0; j < colNumb1; j++)
                    Console.Write("{0,5}", subResult[i, j]);

                Console.WriteLine();
            }

            //To multiply matrices 3 and 4, the number of columns in matrix 3 must be equal to the number of rows in matrix 4
            int rowNumb3 = rand.Next(2, 10);
            int rowNumb4 = rand.Next(2, 10);
            int colNumb3 = rowNumb4;
            int colNumb4 = rand.Next(2, 10);

            int[,] matrix3 = Matrix.CreateMatrix(rowNumb3, colNumb3, rand);
            int[,] matrix4 = Matrix.CreateMatrix(rowNumb4, colNumb4, rand);

            Console.WriteLine("This is result of matrix SUM:");
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                    Console.Write("{0,5}", matrix3[i, j]);

                Console.WriteLine();
            }
            Console.WriteLine("This is result of matrix SUM:");
            for (int i = 0; i < matrix4.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4.GetLength(1); j++)
                    Console.Write("{0,5}", matrix4[i, j]);

                Console.WriteLine();
            }

            //performing the multiplication operation
            int[,] multResult = CalculateMatrix.MultMatrix(matrix3, matrix4);

            Console.WriteLine("This is result of matrix MULT:");
            for (int i = 0; i < multResult.GetLength(0); i++)
            {
                for (int j = 0; j < multResult.GetLength(1); j++)
                    Console.Write("{0,7}", multResult[i, j]);

                Console.WriteLine();
            }
        }
    }
}
