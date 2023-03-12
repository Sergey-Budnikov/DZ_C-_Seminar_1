/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

string Recursion(int N)
{
    if (N == 1) return "1";
    else return Recursion(N - 1) + " " + N;
}

Console.WriteLine($"{Recursion(10)} ");
Console.ReadLine();

/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int Recurs(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + Recurs(M, N - 1);     // Если M<N
    else return N + Recurs(M, N + 1);                // Если M>N
}
Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма элементов в промежутке от M до N = {Recurs(M, N)}");
Console.ReadLine();

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
 
Console.WriteLine(Akkerman(2, 3)); // 9
Console.WriteLine(Akkerman(3, 2)); // 29
Console.WriteLine(Akkerman(0, 0)); // 1
Console.WriteLine(Akkerman(4, 5)); // Stack Overflow 

Console.ReadKey();