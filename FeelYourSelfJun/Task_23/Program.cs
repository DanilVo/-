// Показать таблицу квадратов чисел от 1 до N

int a = 1;
Console.WriteLine("enter your number");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    double c = Math.Pow(a,2);
    Console.WriteLine(c);
    a++;
}


























// void PrintArray(int[,] sqare)
// {
//     for (int rows = 0; rows < sqare.GetLength(0); rows++)
//     {

//         for (int colums = 0; colums < sqare.GetLength(1); colums++)
//         {
//             Console.Write($"{sqare[rows, colums]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] fill)
// {
//     for (int i = 0; i < fill.GetLength(0); i++)
//     {
//         for (int j = 0; j < fill.GetLength(1); j++)
//         {
//             fill[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// int[,] sqare = new int[4, 5];
// PrintArray(sqare);
// FillArray(sqare);
// Console.WriteLine();
// PrintArray(sqare);