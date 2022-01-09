// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
int n = array.Length;
int find = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 123);
    if (array[i] > 10 & array[i] < 99)
    {
        find++;
    }
    Console.Write($",{array[i]}");
}
Console.WriteLine();
Console.WriteLine($"numbers between 10,99 = {find}");