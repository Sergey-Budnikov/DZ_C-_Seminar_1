// FOREACH -перебирает элементы массива по очереди, 
// присваивая каждый раз значение элемента переменной element. 
float[] numbers = {1.56f,5.94f,23.1f,0.34f};
foreach(float element in numbers)
{
    Console.WriteLine(element);
}

Console.ReadLine();

// Parse и Try.Parse
string str = "100";
/* int a = int.Parse(str); или int a = Convert.ToInt32(str); если в строку ввести помимо чисел буквы, 
будет ошибка, при try/catch ошибка не выводится.*/
try
{
    int a = int.Parse(str);
    Console.WriteLine($"Успешная конвертация " + a);
}
catch(Exception)
{
    Console.WriteLine("Ошибка конвертации");
}

Console.ReadLine();
/* Try.Parse не бросает исключения в случае ошибки в отличии от Parse и поэтому
чтобы нам дальше работать с переменной и знать что она конвертировалась правильно,
распарсив строку мы записываем результат в bool, если всё ок, то результат тру, иначе фолс*/
string str = "100";
int a;
bool result = int.TryParse(str,out a);
if(result)
{
    Console.WriteLine($"Успешная конвнртация " + a);
}
else
{
    Console.WriteLine("Ошибка конвертации");
}
