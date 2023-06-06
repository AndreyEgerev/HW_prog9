// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}
//Вывод на экран последовательности чисел
void PrintNumbers( int value )
{
	if ( value > 1 )
	{
		Console.Write($"{value} ");
		PrintNumbers(value-1);
	}
    if (value < 1 )
    {
        Console.Write($"{value} ");
		PrintNumbers(value+1);
    }
    if ( value == 1)
    {
        Console.Write($"{value} ");
    }
}

Console.WriteLine("Вывод натуральных чисел от N до 1");
PrintNumbers(GetNumberInt("Введите число - "));
