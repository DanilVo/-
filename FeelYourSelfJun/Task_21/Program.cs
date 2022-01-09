//Программа проверяет пятизначное число на палиндромом (12321)
Console.WriteLine("enter you number 5 digit: ");
int n = Convert.ToInt32(Console.ReadLine());     // full number
int c = n % 10;                                  // last digit
int j = (n / 10) % 10;                           // one before last digit
int b = n / 10000;                               // first digit
int a = (n / 1000) % 10;                         // second digit
if (c == b & j == a)
{
    Console.WriteLine("poly number");
}
else
{
    Console.WriteLine("not poly");
}