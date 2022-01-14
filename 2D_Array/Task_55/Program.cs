// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

double sumColumn(int[,] arr, int columnNumber)
{
    double sum = 0;
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            if (column == columnNumber)
            {
                sum = sum + arr[row,column];
            }
        }
    }
    double result = sum / Convert.ToDouble(arr.GetLength(1));
    return result;
}

int[,] array = new int[4, 4];
int[,] arr = fillArray(array);
double sum1 = sumColumn(arr, 0);
Console.WriteLine($"first column is: {sum1}");
double sum2 = sumColumn(arr, 1);
Console.WriteLine($"second column is: {sum2}");
double sum3 = sumColumn(arr, 2);
Console.WriteLine($"third column is: {sum3}");
double sum4 = sumColumn(arr, 3);
Console.WriteLine($"fourth column is: {sum4}");