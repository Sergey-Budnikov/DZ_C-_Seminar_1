/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

// string Recursion(int N)
// {
//     if(N==1) return "1";
//     else return Recursion(N - 1) + " " + N;
// }

// Console.WriteLine($"{Recursion(10)} ");

/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int Recurs(int N,int M)
{
    int result;
    for(int i = 0; i < N;i++)
    {
    if(N==M) return M;
    }
    else return result = Recurs(N - 1,M) + Recurs(N - 2,M);
    
}

Console.WriteLine($"{Recurs(10,1)} ");