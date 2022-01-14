// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] array = new int[4,4];
for (int row = 0; row < array.GetLength(0); row++)
{
    for (int column = 0; column < array.GetLength(1); column++)
    {
        array[row,column] = row + column;
        Console.Write($"{array[row,column]} ");
    }
    Console.WriteLine();
}

