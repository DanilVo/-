// В матрице чисел найти сумму элементов главной диагонали

int[,] array = new int[4, 4];
int count = 0;
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(1, 9);
            if (row == column)
            {
                count = count + array[row, column];
            }
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"count: {count}");
}

// int[,] fillArray(int[,] array)
// {
//     for (int row = 0; row < array.GetLength(0); row++)
//     {
//         for (int column = 0; column < array.GetLength(1); column++)
//         {
//             array[row, column] = new Random().Next(1, 4);
//             Console.Write($"{array[row, column]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// void count(int[,] array)
// {
//     int count = 0;
//     for (int row = 0; row < array.GetLength(0); row++)
//     {
//         for (int column = 0; column < array.GetLength(1); column++)
//         {
//             if (row % 2 == 1 & column % 2 == 1)
//             {
//                 count = count + array[row, column];
//             }
//             Console.WriteLine($"count: {count}");

//         }
//     }
// }
// int[,] array = new int[4, 4];
// fillArray(array);
// count(array);