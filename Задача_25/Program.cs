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

int Metod (int a)
{
int i = 1;
int temp = a;
for(; i < numberB; i++)
{
    a = a * temp;
}
return a;
}
Console.WriteLine(Metod(numberA));