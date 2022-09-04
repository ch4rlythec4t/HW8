using System;
class Program
{
    static int[,] CreateSpiralArray(int row, int column)
    {
        int[,] array = new int[row, column];
        int count = 1;

        int currentRow = 0;
        int currentColumn = 0;
        int unfiiedRow = array.GetLength(0);
        int unfiiedColumn = array.GetLength(1);

        array[currentRow, currentColumn] = count;

        while (count < array.GetLength(0) * array.GetLength(1))
        {
            // Движение вправо
            while ((currentColumn < unfiiedColumn - 1) && (array[currentRow, currentColumn + 1] == 0))
            {
                count++;
                currentColumn++;
                array[currentRow, currentColumn] = count;
            }

            // Движение вниз
            while ((currentRow < unfiiedRow - 1) && (array[currentRow + 1, currentColumn] == 0))
            {
                count++;
                currentRow++;
                array[currentRow, currentColumn] = count;
            }

            // Движение влево
            while ((currentColumn > 0) && (array[currentRow, currentColumn - 1] == 0))
            {
                count++;
                currentColumn--;
                array[currentRow, currentColumn] = count;
            }

            // Движение вверх
            while (array[currentRow - 1, currentColumn] == 0)
            {
                count++;
                currentRow--;
                array[currentRow, currentColumn] = count;
            }
        }
        return array;
    }
    static void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
                else Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int dimension1 = 4;
        int dimension2 = 4;

        Console.Clear();
        WriteArray(array: CreateSpiralArray(dimension1, dimension2));
    }
}