// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Максимальное число среди 2х: ");
int num_a = 117;
int num_b = 17;

if (num_a > num_b)
{
    Console.Write(num_a + " - Большее число, ");
    Console.Write(num_b + " - Меньшее число");
}
else if (num_b > num_a)
{
    Console.Write(num_b);
}
else 
{
    Console.Write("Числа равны");
}

