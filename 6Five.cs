using System;

class Program
{
    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Enter the elements for the line {i + 1}:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element {j + 1}: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[,] updatedMatrix = new int[rows, cols + 1];

        for (int i = 0; i < rows; i++)
        {
            int countOnes = 0;
            for (int j = 0; j < cols; j++)
            {
                updatedMatrix[i, j] = matrix[i, j];
                if (matrix[i, j] == 1)
                {
                    countOnes++;
                }
            }

            if (countOnes % 2 != 0)
            {
                updatedMatrix[i, cols] = 1;
            }
        }

        Console.WriteLine("The original matrix: ");
        PrintMatrix(matrix, rows, cols);

        Console.WriteLine("Matrix with an additional column: ");
        PrintMatrix(updatedMatrix, rows, cols + 1);
    }
}