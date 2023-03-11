/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int size = NumFromConsole("размер матрицы");
int[,] matrix62 = new int[size, size];
SpiralFilling(matrix62);
PrintMatrix(matrix62);

int NumFromConsole(string userNumber)  //  Метод для ввода значений с консоли
{
    Console.Write($"Введите значение {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] SpiralFilling(int[,] matrix)  //  Метод для заполнения матрицы по спирали
{
    int value = 1;
    int size = matrix.GetLength(0);
    int maxIndex = size - 1;
    int i = 0;
    int j = 0;

    while (value <= size * size)
    {
        matrix[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < maxIndex)
            j++;
        else if (i < j && i + j >= maxIndex)
            i++;
        else if (i >= j && i + j > maxIndex)
            j--;
        else
            i--;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  // Метод для вывода матрицы int
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10)
                System.Console.Write("0" + matrix[i, j] + " ");
            else
                System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}