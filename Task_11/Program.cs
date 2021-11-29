//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.


int random = new Random().Next(10,99);
Console.WriteLine(random);
int lastdigit = random % 10;
int big = (random / 10) % 10;
if(lastdigit > big)
{
    Console.WriteLine( lastdigit + " is bigest");
}
else
{
    Console.WriteLine(big + " is big");
}

