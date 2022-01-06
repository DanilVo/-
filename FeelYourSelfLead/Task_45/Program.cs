// Показать числа Фибоначчи

int a = 0;
int b = 1;
int c = 1;
Console.Write($"0,1,1");

for (int i = 0; i < 10; i++)
{
    a = b + c;
    b = c + a;
    c = a + b;
    
    Console.Write($" {a},{b},{c},");
}
// int[,] finonacci = new int[4, 4];

// for (int rows = 0; rows < 4; rows++)
// {
//     for (int colums = 0; colums < 4; colums++)
//     {
//         Console.Write($"{finonacci[rows, colums]}");
//     }
//     Console.WriteLine();
// }