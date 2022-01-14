// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] array = new int[3, 3];
int place = 0;
Console.WriteLine("enter your number:");
int k = Convert.ToInt32(Console.ReadLine());
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(1, 3);
            if (k == array[row, column])
            {
                Console.WriteLine($"{k} on position ({row},{column})");
            }
            else
            {
                Console.WriteLine($"no such number on position ({row},{column})");
            }
        }
        Console.WriteLine();
    }
    // Console.Write($"{array[row, column]} ");
}
