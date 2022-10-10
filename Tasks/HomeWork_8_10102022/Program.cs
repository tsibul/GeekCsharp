using static System.Console;
using GeekLib;
Clear();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Write("input rows, columns, minValue, maxValue split by space: ");
string prms = ReadLine();
int[] input = MyMethods.GetArrayFromString(prms);
int[,] array = MyMethods.GetMatrixArray(input[0], input[1], input[2], input[3]);
MyMethods.PrintMatrix(array);
WriteLine();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// SortRowElements(array);
// MyMethods.PrintMatrix(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

MinSumOfRowElements(array);

//Methods
void MinSumOfRowElements(int[,] arr)
{
    int minimumsum = 0;
    int result = 1;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        minimumsum += arr[0, j];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int tmpsum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tmpsum += arr[i, j];
        }
        if (tmpsum < minimumsum)
        {
            minimumsum = tmpsum;
            result = i + 1;
        }
    }
    WriteLine($"min elements sum in row {result}");

}

void SortRowElements(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] newarr = MyMethods.RowFromMatrix(arr, i);
        Array.Sort(newarr);
        MyMethods.ReverseArraySelf(newarr);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = newarr[j];
        }
    }
}