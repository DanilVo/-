// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[] X = { true, false };
bool[] Y = { true, false };
for (int n = 0; n < X.Length; n++)
{
    for (int a = 0; a < Y.Length; a++)
    {
        if (!(X[n] || Y[a]) == (!X[n] && !Y[a]))
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }

}