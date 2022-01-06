// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = new double[5];
int n = array.Length;
double max = 0;
double min = 10;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(10, 90) / 10.0;
    Console.WriteLine(array[i]);
    if (array[i] > max)
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
}
double diff = max - min;

Console.WriteLine($"Difference = {max} - {min} = {diff}");
