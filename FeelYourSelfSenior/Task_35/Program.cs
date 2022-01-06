// Определить, присутствует ли в заданном массиве, некоторое число

int[] array = new int[25];
int[] array1 = new int[25];
int lenght = array.Length;
Console.WriteLine($"new array is: ");
for (int i = 0; i < lenght; i++)
{
    array[i] = new Random().Next(0, 50);
    if (array[i] > 8)
    {
        array1[i] = array[i];
        Console.Write($"{array1[i]},");
    }
}
