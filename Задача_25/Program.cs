// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*Console.WriteLine("Enter numberA");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter numberB");
int numberB = int.Parse(Console.ReadLine());
int i = 1;
int temp = numberA;
while(i < numberB)
{
    numberA = numberA * temp;
    i++;
}
Console.WriteLine(numberA);*/

Console.WriteLine("Enter numberA");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter numberB");
int numberB = int.Parse(Console.ReadLine());

int Metod (int a, int b)
{
int i = 1;
int temp = a;
for(; i < b; i++)
{
    a = a * temp;
}
return a;
}
Console.WriteLine(Metod(numberA, numberB));



/*int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}*/