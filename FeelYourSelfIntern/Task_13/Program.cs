//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("enter your first num:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your second num:");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 % num2 == 0)
{
    Console.WriteLine(" num multiples:");
}
else
{
    Console.WriteLine(num1 % num2);
}