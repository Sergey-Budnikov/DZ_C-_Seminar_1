// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[4];

void FiilArray(double[] FillingArrayValues)
{
    int length = FillingArrayValues.Length;
    int index = 0;
    while(index < length)
    {
        FillingArrayValues[index] = new Random().Next(1, 10) + new Random().NextDouble();
        index++;
    }
}

void PrintArray(double[] ShowArrayValues)
{
    int length = ShowArrayValues.Length;
    int index = 0;
    while(index < length)
    {
        Console.WriteLine($" " + ShowArrayValues[index]);
        index++;
    }
}

FiilArray(array);
PrintArray(array);

int i = 0;
int size = array.Length;
double max = array[0];
double min = array[0];
while(i < size)
{
    if(array[i] < min) min = array[i];
    else if(array[i] > max) max = array[i];
    i++;
}
Console.WriteLine($"Max " + max);
Console.WriteLine($"Min " + min);
double result = max - min;
Console.Write($"Разница между максимальным и минимальным значениями: " + result);
