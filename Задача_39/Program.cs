// Задача 39:
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый на последнем и т.д.)
// [1 2 3 4 5] --> [5 4 3 2 1]
// [6 7 3 6] --> [6 3 7 6]


int EnterNumber(string number)
{
    Console.Write($"{number}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}



int [] CreateArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ArraySize = EnterNumber("Enter array size");
int minValue = EnterNumber("Enter minValue for array");
int maxValue = EnterNumber("Enter maxValue for array");
Console.WriteLine();

int [] numbers = CreateArray(ArraySize, minValue, maxValue);

Console.WriteLine(String.Join(" ", numbers));
Console.WriteLine();

Console.WriteLine(String.Join(" ", ReversArray(numbers)));

int [] ReversArray (int [] set)
{
    
    for (int i = 0; i < set.Length/2; i++)
    {
    int temp = set [i];
    set[i] = set [set.Length - 1 - i];
    set [set.Length - 1 - i] = temp;
    }
    return set;
}
Console.WriteLine();

/*
Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый на последнем и т.д.)
[1 2 3 4 5] --> [5 4 3 2 1]
[6 7 3 6] --> [6 3 7 6]
*/

#nullable disable

System.Console.WriteLine("Enter array legth: ");
int length = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter array minimal: ");
int min = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter array maximal: ");
int max = int.Parse(Console.ReadLine());

int[] MyArray = GetArray(length, min, max);

System.Console.WriteLine($"[{string.Join(", ", MyArray)}]");

int[] GetArray (int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);        
    }
    return result;
}

Array.Reverse(MyArray);

System.Console.WriteLine($"[{string.Join(", ", MyArray)}]");