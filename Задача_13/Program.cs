//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*Console.Write("Введите число: ");
int Value;
if (!int.TryParse(Console.ReadLine(), out Value))
{
    Console.WriteLine("Вы ввели не числовое значение!");
    return;
}

int ValueAbs = Math.Abs(Value);   // Это для того, чтобы проверять отрицательные

if (ValueAbs < 100)
{
    Console.WriteLine("Третьей цифры нет.");
    return;
}

while (ValueAbs > 999)
{
    if (ValueAbs > 999) ValueAbs /= 10;
}

Console.WriteLine($"Третья цифра в числе - {ValueAbs % 10}");
*/


System.Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

int i=1000;

while (i<=number)
{
    i*=10;
}

if (number<100)
{
     System.Console.WriteLine("Третьей цифры нет");
}
else
{
    int numberRes = number%(i/100);

    numberRes = numberRes/(i/1000); 

    System.Console.WriteLine(numberRes);
}
