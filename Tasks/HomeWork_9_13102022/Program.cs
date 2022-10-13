using static System.Console;
using GeekLib;
Clear();

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Write("input N: ");
int number = Convert.ToInt32(ReadLine()!);
WriteLine(GetNumbersDecrement(number));
WriteLine();


string GetNumbersDecrement(int n)
{
    return (n == 1) ? n.ToString() : n + " " + GetNumbersDecrement(n - 1);
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Write("input M: ");
int mumber = Convert.ToInt32(ReadLine()!);
WriteLine($"Sum from {number} to {mumber} => {GetSunNToM(number, mumber)}");
WriteLine();


int GetSunNToM(int n, int m)
{
    if (n == m) return n;
    return (n > m) ? GetSunNToM(n - 1, m) + n : GetSunNToM(m - 1, n) + m;
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
WriteLine($"Akkerman({number},{mumber}) = {AkkermanFunction(number, mumber)}");

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}