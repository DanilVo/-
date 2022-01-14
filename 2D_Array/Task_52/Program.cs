// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] array = new int[7, 7];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(2, 4);
        if (i % 2 == 0 & j % 2 == 0)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
