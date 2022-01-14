// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] fillArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row,column] = new Random().Next(1,9);
            Console.Write(array[row,column]);
        }
    Console.WriteLine();
    }
    return newArray;
}

int[,] arrangeArray(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            
        }
    }
}

int[,] array = new int[6,6];
int[,] arr = fillArray(array);