// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

int[,] fillArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(1, 7);
            Console.Write(array[row, column]);
        }
        Console.WriteLine();
    }
    return array;
}
 

int[,] swapArray(int[,] arr)
{
    int[,] array1 = new int[4,4];
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {

            array1[row,column] = arr[column,row];
            Console.Write(array1[row, column]);
        }
        Console.WriteLine();
    }
    return array1;
}

int[,] array = new int[4, 4];
int[,] arr = fillArray(array);
Console.WriteLine();
swapArray(arr);