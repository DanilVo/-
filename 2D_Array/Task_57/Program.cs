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

int[,] arrangeArray(int[,] arr, int columnNumber)
{
    int max = 0;
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            if (row == columnNumber)
            {
                if (arr[row,column] > max)
                {
                    max = arr[row,column];

                }
            Console.Write(max);
            }
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] array = new int[4, 4];
int[,] arr = fillArray(array);
Console.WriteLine();
arrangeArray(arr, 0);