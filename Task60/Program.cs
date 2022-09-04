using System;
class Program
{
    static int[,,] CreateOrderedArray(int n, int m, int l)
    {
        int[,,] array = new int[n,m,l];
        int count = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        { 
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i,j,k] = count++;
                }
            }

        }
        return array;
    }
    
    static int[,,] UnorderedArray(int[,,] orderedArray)
    {
        int[,,] unorderedArray = orderedArray;
        int temp = 0;

        for (int i = 0; i < unorderedArray.GetLength(0); i++)
        {
            for (int j = 0; j < unorderedArray.GetLength(1); j++)
            {
                for (int k = 0; k < unorderedArray.GetLength(2); k++)
                {
                    int iRand = new Random().Next(i);
                    int jRand = new Random().Next(j);
                    int kRand = new Random().Next(k);

                    temp = unorderedArray[iRand, jRand, kRand];
                    unorderedArray[iRand, jRand, kRand] = unorderedArray[i, j, k];
                    unorderedArray[i, j, k] = temp;
                }
            }
        }
 


        return unorderedArray;
    }

    static void WriteArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                }
            }
            Console.WriteLine();
        }
            }
    static void Main()
    {
        int dimension1 = 2;
        int dimension2 = 2;
        int dimension3 = 2;

        Console.Clear();
        Console.WriteLine("Упорядоченный 3-мерный массив: ");
        WriteArray(array: CreateOrderedArray(dimension1, dimension2, dimension3));
        Console.WriteLine();
        Console.WriteLine("Неупорядоченный 3-мерный массив: ");
        WriteArray(array: UnorderedArray(CreateOrderedArray(dimension1, dimension2, dimension3)));
    }
}