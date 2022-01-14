// адать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] masive = new int[10];
int n = masive.Length;
int a = 0;
int b = 0;
for (int i = 0; i < n; i++)
{
    masive[i] = new Random().Next(100, 999);
    Console.WriteLine(masive[i]);
    if (masive[i] % 2 == 1)
    {
        b++;
        // Console.WriteLine($"not even= {b}");
    }
    if (masive[i] % 2 == 0)
    {
        a++;
        // Console.WriteLine($"even= {a}");
    }
}
Console.WriteLine($"even = {a} not even = {b}");