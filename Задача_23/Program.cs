// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (N >= i)
{
    Console.Write(i*i*i + ", ");
    i++;
}

// Второе решение для того чтобы убрать запятую в конце последнего значения N.

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (N - 1 >= i)
{
    Console.Write(i*i*i + ", ");
    i++;
}
Console.Write(i*i*i);