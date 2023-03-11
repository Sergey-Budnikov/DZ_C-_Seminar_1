// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number == 6 || number == 7)
// {
//     Console.WriteLine("Выходной");
// }
// else
// {
//     Console.WriteLine("Не выходной");
// }

switch(number)
{
case 1: Console.WriteLine("Понедельник"); Console.Write("Рабочий день"); break;
case 2: Console.WriteLine("Вторник"); Console.Write("Рабочий день"); break;
case 3: Console.WriteLine("Среда"); Console.Write("Рабочий день"); break;
case 4: Console.WriteLine("Четверг"); Console.Write("Рабочий день"); break;
case 5: Console.WriteLine("Пятница"); Console.Write("Рабочий день"); break;
case 6: Console.WriteLine("Суббота"); Console.Write("Выходной день"); break;
case 7: Console.WriteLine("Воскресенье"); Console.Write("Выходной день"); break;
default:Console.WriteLine("Error"); break;
}