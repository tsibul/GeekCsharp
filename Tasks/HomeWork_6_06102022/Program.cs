using static System.Console;
using GeekLib;
Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

CountPositive();
//метод не очень нужен тут

void CountPositive()
{
    int count = 0;
    bool operate = true;
    int number;
    while (operate)
    {
        Write("Input number if you want to continue or anykey to stop: ");
        string input = (ReadLine());
        if (int.TryParse(input, out number))
        {
            if (number > 0) count++;
        }
        else operate = false;
    }
    WriteLine($"Positive numbers = {count}");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// тут вообще не вижу смысла в методе при вводе с клавиатуры всех 4
// надеюсь, надеюсь в  задачу не входило решение в общем виде и вычисление обратных матриц? =)

WriteLine("input k1 b1 k2 b2 divided by space");
int [] linearindexes = MyMethods.GetArrayFromString(ReadLine()!);
double k1 = Convert.ToDouble(linearindexes[0]);
double b1 = Convert.ToDouble(linearindexes[1]);
double k2 = Convert.ToDouble(linearindexes[2]);
double b2 = Convert.ToDouble(linearindexes[3]);
if (k1 != k2){
double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;
WriteLine($"for y={k1}x+{b1} and y={k2}x+{b2} result is ({x},{y})");}
else if (k1 == k2 && b1 != b2) WriteLine($"for y={k1}x+{b1} and y={k2}x+{b2} no solution");
else WriteLine($"for y={k1}x+{b1} and y={k2}x+{b2} every x is solution");

