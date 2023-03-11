// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/* ПЕРВОЕ РЕШЕНИЕ */

int[] array = {1, 2, 3, 4, 5, 6, 7, 8};

void PrintArray(int[] Collection)
{
    int n  = Collection.Length;
    int i = 0;
    while( i < n)
    {
        Console.WriteLine(Collection[i]);
        i++;
    }
}

PrintArray(array);

/* ВТОРОЕ РЕШЕНИЕ */

int[] arr = new int[8];

void FillArray (int[] ArrayMethod)
{
    int length = ArrayMethod.Length;
    int index = 0;
    while(index < length)
{
    ArrayMethod[index] = new Random().Next(1, 50);
    index++;
}
}

FillArray(arr);
PrintArray(arr);