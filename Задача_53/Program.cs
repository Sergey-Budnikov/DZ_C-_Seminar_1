/*Задайте двухмерный массив. Напишите программу, 
  которая поменяет местами первую и последнюю строки. */

int [,] matrix = new int[4,4];
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
void Reverse(int[,] array)
{
    for( int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = temp;
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Reverse(matrix);
PrintArray(matrix);

// Второй вариант

int [,] FillArray(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows,colums];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(min, max);
        }
    }
    return array;
}

int [,] PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine();
    }
    return array;
}

void ReversRows(int[,] array)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(1)-1,i];
        array[array.GetLength(1)-1,i] = temp;
    }
}
 int[,] arr = FillArray(4,4,1,10);
 PrintArray(arr);
 ReversRows(arr);
 Console.WriteLine();
 PrintArray(arr);