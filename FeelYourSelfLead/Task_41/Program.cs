// Выяснить являются ли три числа сторонами треугольника

Console.WriteLine("A side is = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("B side is = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("C side is = ");
double c = Convert.ToDouble(Console.ReadLine());

if (a + b > c & b + c > a & c + a > b)
{
    Console.WriteLine("it is triangle");
}
else
{
    Console.WriteLine("not triadngle");
}

