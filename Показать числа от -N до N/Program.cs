int num = 1;
int index = 0;
int max = 10;
while(index<max)
{
    if(index<max)
    {
        Console.WriteLine(num);
        if(index == 0)
        {
            num = num + 1;
            Console.WriteLine(num);
        }
    }
    num = num +2;
    index++;
}
Console.WriteLine(num);
