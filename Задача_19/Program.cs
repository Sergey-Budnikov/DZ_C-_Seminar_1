// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

  
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); // Моё число 123321
int result = 0;                             // Перевернутое число
int temp = number;                          // 3я переменная копирующая number
while (temp > 0) 
{
    int intermediate = temp % 10;           // Число, из которого собирается
    temp = temp / 10;                       // целый result, а не просто набор цифр
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
    
