﻿// В двумерном массиве n×k заменить четные элементы на противоположные

int[,] array = new int[4,4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
        if (array[i,j] % 2 == 0)
        {
            array[i,j] = array[i,j] * -1;
        }
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}