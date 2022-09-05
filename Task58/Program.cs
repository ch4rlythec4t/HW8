using System;
class Program
{
    static int[,] CreateMatrix(int n, int m)
    {
        int[,] matrix = new int[n, m];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(100);
            }
        }
        return matrix;
    }
    static int[,] Multiplication(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;


    }
    static void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int dimension1 = 2;
        int dimension2 = 2;
        int[,] matrix1 = CreateMatrix(dimension1, dimension2);
        int[,] matrix2 = CreateMatrix(dimension1, dimension2);

        Console.Clear();
        Console.WriteLine("Первая матрица: ");
        WriteArray(array: matrix1);
        Console.WriteLine();
        Console.WriteLine("Вторая матрица: ");
        WriteArray(array: matrix2); 
        Console.WriteLine();
        Console.WriteLine("Произведение матриц: ");
        WriteArray(array: Multiplication(matrix1, matrix2)); ;
    }
}