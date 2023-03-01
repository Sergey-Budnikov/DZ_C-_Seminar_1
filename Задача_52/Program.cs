/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();

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
Console.WriteLine("Введите размер матрицы"); 
Console.Write("Введите количество строк: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int M = int.Parse(Console.ReadLine());
int[,] matrix = new int[N, M];
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
int[] summ = new int[M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    summ[j] += matrix[i, j];      // подсчет суммы колонки, либо summ[i] += matrix[j, i];
                    // summ[i] += matrix[i, j]; подсчет суммы строки, либо 
                } 
            }
            Console.WriteLine();
            Console.Write("Среднее арифметичесое столбцов:");
            foreach (double elem in summ)
            {    
                Console.Write($"  {elem/M}"); 
            }


