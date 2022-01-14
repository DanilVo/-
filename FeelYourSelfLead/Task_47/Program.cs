// Написать программу копирования массива

var source = new[] { "Ally", "Bishop", "Billy" };
var target = new string[3];
int n = source.Length;
for (int i = 0; i < n; i++)
{
    target[i] = source[i];
    Console.WriteLine(target[i]);
}