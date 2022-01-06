//  Написать программу замену элементов массива на противоположные

int[] array = new int[12];
int n = array.Length;
int a = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(12);
    a = (-1) * array[i];
    Console.WriteLine(a);
}












// int[] array = new int[12];
// int n = array.Length;
// int a = 0;
// for (i = 0; i < n; i++)
// {
//     array[i] = new Random().Next(13);

// }
// Console.WriteLine(array[i]);
