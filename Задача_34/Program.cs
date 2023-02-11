// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];

void FiilArray(int[] FillingArrayValues)
{
    int length = FillingArrayValues.Length;
    int index = 0;
    while(index < length)
    {
        FillingArrayValues[index] = new Random().Next(99, 1000);
        index++;
    }
}

void PrintArray(int[] ShowArrayValues)
{
    int length = ShowArrayValues.Length;
    int index = 0;
    while(index < length)
    {
        Console.WriteLine(ShowArrayValues[index]);
        index++;
    }
}

FiilArray(array);

int i = 0;
int size = array.Length;
int count = 0;
while(i < size)
{
    if(array[i] % 2 == 0)
    {
        count = count + 1;
    }
    i++;
}

PrintArray(array);
Console.WriteLine("Количество положительных чисел: ");
Console.Write(count);