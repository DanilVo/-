// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[10];
int n = array.Length;
int count = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 2);
    if (i % 2 == 1)
    {
        count = count + array[i];
        Console.WriteLine($"{i} = {array[i]}");
    }
    
}
Console.WriteLine(count);

