// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[6];

void FiilArray(int[] FillingArrayValues)
{
    int length = FillingArrayValues.Length;
    int index = 0;
    while(index < length)
    {
        FillingArrayValues[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] ShowArrayValues)
{
    int length = ShowArrayValues.Length;
    int index = 0;
    while(index < length)
    {
        Console.Write($" " + ShowArrayValues[index]);
        index++;
    }
}

FiilArray(array);

int i = 1;
int size = array.Length;
int sum = 0;
while(i < size)
{
    sum = sum + array[i];
    i+=2;
}

PrintArray(array);
Console.Write(" - Сумма элементов с нечетными индексами: ");
Console.Write(sum);
