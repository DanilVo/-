// Подсчитать сумму цифр в числе


Console.WriteLine("enter your number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result= 0;
while(a>0)
{
    result = result + (a%10);
    a=a/10;
}
Console.WriteLine(result);
