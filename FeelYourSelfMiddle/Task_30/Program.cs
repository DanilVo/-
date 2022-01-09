//Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("enter your number");
int a = 1;
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    double c = Math.Pow(a, 2) * a;
    if(c%2==0)
    {
    Console.WriteLine($"{a} = {c}");
    }
    a++;
}
