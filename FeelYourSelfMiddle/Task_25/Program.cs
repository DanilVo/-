// Найти сумму чисел от 1 до А

int a = 1;
Console.WriteLine("enter your number:");
int b = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < b; i++)
{
    Console.WriteLine($"{a}+{a}={a + a}");
    a++;
}