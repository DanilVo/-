// Написать программу масштабирования фигуры


int[,] zoom(int k, int[,] square)
{
  
    for (int rows = 0; rows < square.GetLength(0); rows++)
    {
        for (int colums = 0; colums < square.GetLength(1); colums++)
        {
            if (square[rows, colums] != 0)
            {
                square[rows, colums] = square[rows, colums] + k;
            }
        }
    }
    return square;
}

void showMatrix(int[,] array)
{
    int max = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if (array[row, column] > max)
            {
                max = array[row, column];
            }
           // Console.Write($"-{array[row, column]}-");

        }
        //Console.WriteLine();
    }
    int i = 0;
    while (i < max)
    {
        int j = 0;
        while (j < max)
        {
            Console.Write("*");
            j++;
        }
        i++;
        Console.WriteLine();
    }
    // Console.Write(max);
}
int[,] square = { { 0, 0 }, { 2, 0 }, { 2, 2 }, { 0, 2 } };
Console.WriteLine("enter your number:");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("orginal matrix");
showMatrix(square);
Console.WriteLine();
int[,] result = zoom(k, square);
Console.WriteLine("rebuilded matrix");
showMatrix(result);