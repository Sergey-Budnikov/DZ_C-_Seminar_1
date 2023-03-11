/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();
int SetNumber(string numberName)
{
    Console.Write(numberName);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine();
    }
}
void Enumeration(int[,] array, int num)
{
    bool n = false;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == num) n = true;       
        }
    }
     Console.WriteLine();
            if (n)
                Console.WriteLine("Число есть в массиве");
            else
                Console.WriteLine("Такого числа в массиве нет");
                Console.WriteLine();
}
int[,] matrix = new int[4,4];

FillArray(matrix);
PrintArray(matrix);
int number = SetNumber("Введите число: ");
Enumeration(matrix, number);

       
