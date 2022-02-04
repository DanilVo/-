// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int[] calculateMin(int[,] arr, int[] arr1)
{
    int result = 0;
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            result = result + arr[row, column];
            arr1[row] = result;
        }
        result = 0;
        Console.Write(arr1[row]);
        Console.WriteLine();
    }
    int min = 0;
    for (int num = 0; num < arr1.GetLength(0); num++)
    {
        if (arr1[min] > arr1[num])
        {
            min = num;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"the smallest line is {min + 1}");
    return arr1;
}

int[,] array = new int[4, 4];
int[] arr1 = new int[4];
int[,] arr = fillArray(array);
Console.WriteLine();
calculateMin(arr, arr1);
Console.WriteLine();
