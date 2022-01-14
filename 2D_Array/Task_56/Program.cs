// Написать программу, которая обменивает элементы первой строки и последней строки

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

int[,] swapNum(int[,] arr)
{
    int first = 0;
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            if (column == 0)
            {
                first = arr[row, column];
                arr[row, column] = arr[row, arr.GetLength(1) - 1];
                arr[row, arr.GetLength(1) - 1] = first;
            }
            Console.Write(arr[row, column]);
        }
        Console.WriteLine();
    }
    return arr;
}
int[,] array = new int[4, 4];
int[,] arr = fillArray(array);
Console.WriteLine();
swapNum(arr);
