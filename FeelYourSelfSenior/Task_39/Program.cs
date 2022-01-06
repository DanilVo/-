// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = new int[4];
int n = array.Length;
int count = 0;

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 4);
Console.WriteLine(array[i]);

}
Console.WriteLine("--------------");

for (int i = 0; i < n ; i++)
{
    if (i >= n / 2)
    {
    int lastItem = array[n - 1 - i];
    count = array[i] + lastItem;
    Console.WriteLine($"{count} = {array[i]} + {lastItem}");
    }
}
