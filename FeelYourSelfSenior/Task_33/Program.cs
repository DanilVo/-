// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива


int[] array = new int[12];
int n = array.Length;
int a = 0;
int b = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-6, 6);
    if (array[i] < 0)
    {
        a = a + array[i];
    }
    if (array[i] > 0)
    {
        b = b + array[i];
    }
    Console.Write(array[i]);
    Console.WriteLine();
}
Console.WriteLine($"negative={a} positive={b}");
// int[] array1 = new int[12];
// int c = array1.Length;
// for (int i = 0; i < c; i++)
// {
//     array1[i] = new Random().Next(-6, 6);
//     Console.WriteLine(array1[i]);
// }


// Console.WriteLine();

