//Найти расстояние между точками в пространстве 2D/3D

int x = 10;
int y = 20;
int z = 30;

int x1 = 40;
int y1 = 50;
int z1 = 60;

double a = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));

double b = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2) + Math.Pow((z1 - z), 2));

Console.WriteLine($" 2D = {a}, 3D = {b}");