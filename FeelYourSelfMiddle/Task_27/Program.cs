// Определить количество цифр в числе
Console.WriteLine("enter your number: ");
int func(int b)
{
    int count = 0;
    while (b > 0)
    {
        b = b / 10;
        count++;
    }
    return count;
}
int b = Convert.ToInt32(Console.ReadLine());
int count = func(b);
Console.WriteLine(count);