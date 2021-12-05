//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("enter your day number: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n>7 || n<1)
{
    Console.WriteLine("not such day");
}
else
{
    if(n==6 || n==7)
    {
        Console.WriteLine("weekend");
    }
    else
    {
        Console.WriteLine("week day");
    }
}