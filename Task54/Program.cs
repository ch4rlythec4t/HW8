using System;
class program
{
    static int[,] DescendingOrder(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int count = 0;
            while (count < array.GetLength(1))
            {
                int min = array[i, 0];

                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    else
                    {
                        array[i, j - 1] = array[i, j];
                        array[i, j] = min;
                    }
                }
                count++;
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
                Console.Write(" " + array[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] disorderedArray = {{1, 4, 7, 2, 11},
                                {5, 9, 2, 34, 3},
                                {8, 4, 45, 2, 4}};

        Console.Clear();
        Console.WriteLine("Исходный массив: ");
        WriteArray(disorderedArray);
        Console.WriteLine();

        int[,] newArray = DescendingOrder(disorderedArray);
        Console.WriteLine("Упорядоченный массив: ");
        WriteArray(array: newArray);
    }
}
