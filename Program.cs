//Функция Аккермана
int m = 2; // Можно поменять значение для проверки
int n = 3; // Можно поменять значение для проверки
int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
static int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    return 0; // Для случая, если входные данные неверные
}



