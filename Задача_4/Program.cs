// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Максимальное число среди 3х: ");
int num_a = 22;
int num_b = 3;
int num_c = 9;
int max = num_a;

if (num_b > max)
{
    max = num_b;
}
if (num_c > max)
{
    max = num_c;
}

Console.Write(max);
