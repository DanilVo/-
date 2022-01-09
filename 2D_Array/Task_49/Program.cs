// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] array = new double[4,4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(20,40) /10.0;
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}