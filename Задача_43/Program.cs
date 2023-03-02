/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Enter a value b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;

GetPoint( b1, k1, b2, k2, out x, out y);
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine($"The point of intersection of two straight lines X: {x}; Y: {y}");
Console.ReadLine();

void GetPoint(double inB1, double inK1, double inB2, double inK2, out double X, out double Y)
{
    X = (inB2 - inB1)/(inK1 - inK2);
    Y = inK1 * X - inB1;
}

// Твк как метод ничего не возвращает, 
// а нам нужно вывести на экран полученные в результате вычисления x и y,
// мы присваиваем этим переменным "out", который в свою очередь меняет первичные
// значения наших переменных на строках 15 и 16 и соот-но консоль выводит их новые значения. 