// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] fillArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(1, 9);
            Console.Write(array[row, column]);
        }
        Console.WriteLine();
    }
    return array;
}

int[,] arrangeArray(int[,] arr)
{
    // int currentRow = 0;
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        int maxColumn = 0;
        for (int column = 0; column < arr.GetLength(1) - 1; column++)
        {
            for (int i = column + 1; i < arr.GetLength(1); i++)
            {
                if (arr[row, i] > arr[row,maxColumn])
                {
                    maxColumn = i;
                }
            }
            int temp = arr[row,column];
            arr[row,column] = arr[row,maxColumn];
            arr[row,maxColumn] = temp;
        Console.Write(arr[row,column]);
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] array = new int[4, 4];
int[,] arr = fillArray(array);
Console.WriteLine();
arrangeArray(arr);