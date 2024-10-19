//Вывод натуральных чисел в промежутке от M до N
//static void Main(string[] args);
int M = 1; // Можно поменять значение для проверки
int N = 5; // Можно поменять значение для проверки
 static void PrintRange(int M, int N)
{
if (M > N) return; // Базовый случай: если M больше N,прекращаем рекурсию
Console.Write(M);
if (M < N) Console.Write(", ");
PrintRange(M + 1, N);
}

Console.WriteLine("Числа в промежутке:");
PrintRange(M, N);

