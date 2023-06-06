// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

//Функция подсчета суммы чисел
int SummNumbers(int m, int n)
{
	if (m <= n)
	{
		return n+SummNumbers(m, n-1);
	}
    return 0;
}

Console.Clear();
Console.WriteLine("Нахождение суммы натуральных чисел в промежутке от M до N");
int numberM = GetNumberInt("Введите число M - ");
int numberN = GetNumberInt("Введите число N - ");
int summa = SummNumbers(numberM, numberN);
Console.WriteLine($"Сумма чисел - {summa}");