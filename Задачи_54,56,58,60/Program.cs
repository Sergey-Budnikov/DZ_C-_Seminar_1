/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.WriteLine("Задача 54");
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

void SortingRows (int [,] matrix)  // Сортировка строк от большего элемента к меньшему.
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i,k] < matrix [i,k+1])
                {
                    int temp = matrix [i,k+1];
                    matrix [i,k+1] = matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
            
        }
    }
}
int[,] matr = FillArray(4,4,1,10);
PrintArray(matr);
Console.WriteLine();
SortingRows(matr);
PrintArray(matr);
Console.WriteLine();

/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Задача 56");
int MinRowSum(int[,] matrix)  
{
    int row = 0;
    int? min = null;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (min == null) min = sum;
        else if (sum < min)
        {
            min = sum;
            row = i;
        }
        System.Console.WriteLine($"Сумма элементов {i} строки равна {sum}");
    }
    return row;
}
PrintArray(matr);
MinRowSum(matr);
Console.WriteLine();

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine("Задача 58");
int[,] NewMatrix(int[,] matrix1, int[,] matrix2)  
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}
int[,] matr1 = FillArray(4,4,1,10);
PrintArray(matr);
Console.WriteLine();
int[,] matr2 = FillArray(4,4,1,10);
PrintArray(matr);
Console.WriteLine();
PrintArray(NewMatrix(matr1, matr2)); 
Console.WriteLine();

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.WriteLine("Задача 60");
int sizeX = SetNumber("размер X");
int sizeY = SetNumber("размер Y");
int sizeZ = SetNumber("размер Z");
int[,,] matrix = CubeMatrix(sizeX, sizeY, sizeZ);
Print3dMatrix(matrix);
int SetNumber(string numberName)
{
    Console.Write($"{numberName} ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,,] CubeMatrix(int valueX, int valueY, int valueZ)  
{
    int[,,] matrix = new int[valueX, valueY, valueZ];

    if ((valueX * valueY * valueZ) > 90) Console.WriteLine("Слишком большой размер. Количество значений не должно превышать 90");
    int[] array = new int[90];
    PutOrder(array);
    Shuffle(array);

    for (int i = 0; i < valueX * valueY * valueZ;)
    {
        for (int x = 0; x < valueX; x++)
        {
            for (int y = 0; y < valueY; y++)
            {
                for (int z = 0; z < valueZ; z++)
                {
                    matrix[x, y, z] = array[i];
                    i++;
                }

            }
        }
    }
    return matrix;
}

void Print3dMatrix(int[,,] matrix)  
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                System.Console.Write($"{matrix[x, y, z]} ({x}, {y}, {z}) ");
            }
            System.Console.WriteLine();
        }
    }
}

void PutOrder(int[] Numbers)  //  Метод заполнение одномерного массива по порядку
{
    int length = Numbers.Length;

    for (int i = 0; i < length; i++)
    {
        Numbers[i] = i + 10;
    }
    return;
}

int[] Shuffle(int[] arr)  // Метод для перемешивания чисел
{
    Random rand = new Random();

    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);

        int temp = arr[j];
        arr[j] = arr[i];
        arr[i] = temp;
    }
    return arr;
}