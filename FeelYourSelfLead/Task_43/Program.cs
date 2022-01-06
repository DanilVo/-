// // Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("enter your number");
int a = Convert.ToInt32(Console.ReadLine());
string b = "";

while (a >= 1)
{
    b = (a % 2) + b;
    a = a / 2;
}
Console.WriteLine(b);
