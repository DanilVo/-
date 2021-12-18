// // Найти кубы чисел от 1 до N

int a = 1;
Console.WriteLine("enter your number");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    double c = Math.Pow(a,2)*a;
    Console.WriteLine($"{a} = {c}");
    a++;
}
