using System;
class program
{

    static int SmallestAmountLine(int[,] array)
    {
        int min = 0;
        int[] Sum = new int[array.GetLength(0)];
        int NumLine = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Sum[i] += array[i, j];
            }
            if (i == 0)
            {
                min = Sum[i];
                NumLine = i + 1;
            }
            else if (Sum[i] < min)
            {
                min = Sum[i];
                NumLine = i + 1;
            }
        }
        return NumLine;
    }

    static void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(" " + array[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] someArray = {{1, 4, 7, 2,},
                            {5, 9, 2, 3},
                            {8, 4, 2, 4},
                            {5, 2, 6, 7}};

        Console.Clear();
        Console.WriteLine("Исходный массив: ");

        WriteArray(someArray);
        Console.WriteLine();
        Console.WriteLine("Номер строки с наименьшей суммой элементов: " + SmallestAmountLine(array: someArray));

    }
}