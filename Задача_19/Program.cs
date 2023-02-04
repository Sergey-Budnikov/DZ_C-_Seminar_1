// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int number;   
Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine());
int result = 0;
int temp = number;
while (temp > 0) 
{
    int intermediate = temp % 10;
    temp = temp / 10;
    result = result * 10 + intermediate;
}

Console.WriteLine(result);

if (result == number)
{
   Console.Write("Число Палиндром");
}
else
{
   Console.Write("Число Не Палиндром");   
}
        