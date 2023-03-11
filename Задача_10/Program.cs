// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число");

int number123 = Convert.ToInt32(Console.ReadLine());
if(number123>999)
{
    Console.Write("Число больше 3х символов");
}
else if(number123<99)
{
    Console.Write("Число меньше 3х символов");
}
else
{
    int number23 = number123 % 100;  // int number12 = number123 / 10;
    int number2 = number23 / 10;     // int number2 = number12 % 10;}
    Console.WriteLine(number2);
}
