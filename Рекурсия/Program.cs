// Разработать рекурсивную функцию, которая находит сумму элементов массива:
// S = A[0] + A[1] + … + A[n], где n – количество элементов массива.

int Sum(int i, int[] A, int n)
{
    if (i==n-1)
        return A[i];
    else
        return A[i]+Sum(i+1,A,n);
}

int[] array = {2,5,6,8,1,9};
int sum = Sum(0,array,6);   // либо Console.WriteLine(Sum(0,array,6)); 
Console.WriteLine(sum);  



// Нахождение факториала.

int Factorial(int n)
{
    if(n == 1) return n;
    else return n * Factorial(n - 1);
}

Console.WriteLine($"Факториал равен: {Factorial(10)}");  // либо Console.WriteLine(Factorial(5));  

// вычисление факториала - способ 2
/*int Fact1(int n, int i)
{
    if (i==n)
        return n; // условие завершения рекурсивного процесса
    else
        return i*Fact1(n, i+1); // переход к следующему числу i+1
}*/



// Нахождение наибольшего общего делителя (алгоритм Евклида).

int MaxDiv(int n, int m)
{
    if (n==m)
        return n;
    else
    if (n>m)
        return MaxDiv(n-m, m);
    else
        return MaxDiv(n, m-n);
}
Console.WriteLine($"Наибольший делитель: {MaxDiv(24, 96)}");



// В данном примере реализована рекурсивная функция Count(), которая определяет количество вхождений заданного символа c в строке s. Функция получает 3 параметра:

// символ c, который нужно сравнить с каждым символом строки s;
// строка s;
// дополнительная переменная i, которая есть счетчиком рекурсивного цикла.

// подсчет символа c в строке символов s
/*int Count(char c, string s, int i)
{
    if (i==s.length()) // условие окончания рекурсивного процесса - вся строка пройдена
        return 0;
    else
    {
        if (c == s[i]) // если символ найден
            return Count(c,s,i+1)+1; // увеличить количество найденных символов на 1
        else
            return Count(c,s,i+1); // иначе, перейти к обработке следующего символа
    }
}*/

