int[] numbers = { 17, 21, 34, 43, 25 };
int max = 0;
int size = numbers.Length;
for(int index = 0; index < size; index++)
{
     int newmax = numbers[index];
     if(max<newmax)
     {
          Console.WriteLine(newmax);
     }
}




//    int num1 = 5;
//int num2 = 16;
//int num3 = 2;
//int max = num1;
//if (num2 > max)
//{
//    max = num2;
//}
//if (num3 > max)
//{
//    max = num3;
//}
//Console.WriteLine(max);

     //int newmax = numbers[+index];
    // if(newmax>max)
     //{
    //      Console.WriteLine(newmax);
    // }