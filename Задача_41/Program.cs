// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// считать число с консоли
int Promt(string message)
{
    Console.Write(message);  // Вывести сообщение
    string value = Console.ReadLine();  // считывает с консоли строку
    int result = Convert.ToInt32(value);  // преобразует строку в целое число
    return result;  // возвращает результат
}
// вывести массив
int[] InputArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Введите {i + 1}-й элемент ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]} ");
    }
}
int CountPositivNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Promt("Введите количество элементов: ");
int[] Massiv = InputArray(length);
PrintArray(Massiv);
Console.WriteLine($"Количество элементов больше 0 - {CountPositivNumbers(Massiv)}");
