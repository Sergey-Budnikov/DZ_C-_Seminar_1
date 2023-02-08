// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*Console.WriteLine("Enter Number");
int number = int.Parse(Console.ReadLine());
int sum = 0;

while(number > 1)
{
    int temp = number % 10;
    number = number / 10;
    sum = sum + temp;
}

Console.Write(sum);*/

Console.WriteLine("Enter Number");
int number = int.Parse(Console.ReadLine());
int sum = 0;

int Metod(int s, int n)
{
    while(n > 1)
    {
        int variable = n % 10;
        n = n / 10;
        s = s + variable;
    }
    return s;
}

int Summa = Metod(sum, number);
Console.Write(Summa);