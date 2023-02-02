// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число");
int number123 = Convert.ToInt32(Console.ReadLine());
int number23 = number123 % 100;
int number2 = number23 / 10;
Console.WriteLine(number2);