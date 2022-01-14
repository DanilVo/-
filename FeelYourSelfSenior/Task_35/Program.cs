// Определить, присутствует ли в заданном массиве, некоторое число


int[] array = new int[12];
int n = array.Length;
Console.WriteLine("What num you want to check?");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 13);
    if (array[i] == a)
    {
        Console.WriteLine("there is such number");
    }
    else
    {
        Console.WriteLine("no such number");
    }
}
