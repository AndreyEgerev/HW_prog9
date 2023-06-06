// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

//Функция Аккермана 
int Akkerman(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0) 
        {
            return Akkerman(m - 1, 1);
        }
    else 
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

//
bool CheckNumber (int value)
{
    if (value > 0 ) return true;
    else return false;
}

Console.Clear();
Console.WriteLine("Вычисление функции Аккермана для двух неотрицательных чисел M и N");
int numberM = GetNumberInt("Введите число M - ");
int numberN = GetNumberInt("Введите число N - ");
if(numberM < 0 || numberN < 0)
{
    Console.WriteLine("Введено отрицательное число в качестве аргумента");
}
else
{
    Console.WriteLine(Akkerman(numberM,numberN));
}