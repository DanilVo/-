// Составить частотный словарь элементов двумерного массива


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