// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
int n = array.Length;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.WriteLine(array[i]);
}