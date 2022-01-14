// Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("enter your numbers:");
int count = 0;
for (int i = 0; i < 20; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        count++;
    }
     Console.WriteLine($"you entered {count} numbers bigger than 0.");
}
