//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

void findsqare()
{
Console.WriteLine("enter you number");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your number");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 & y > 0)
{
    
    Console.WriteLine("sqare 1");
}
if (x < 0 & y > 0)
{
    Console.WriteLine("sqare 2");
}
if (x < 0 & y < 0)
{
    Console.WriteLine("sqare 3");
}
if (x > 0 & y < 0)
{
    Console.WriteLine("sqare 4");
}
}

findsqare();