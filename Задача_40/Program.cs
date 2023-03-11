/*
Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

#nullable disable

System.Console.WriteLine("enter coordinates point A ");
int A = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point B");
int B = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point C");
int C = int.Parse(Console.ReadLine());

bool IsTriangle(int a,int b,int c)
{
    return (((a+b)>c)&&((a+c)>b)&&((b+c)>a));
}
if  (IsTriangle(A, B, C))
{
    System.Console.WriteLine("Can exist ");
}
else
{
    System.Console.WriteLine("Impossible ");
}