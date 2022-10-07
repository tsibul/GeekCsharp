using static  System.Console;
using GeekLib;
Clear();


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Write("Input rows columns minimum and maximum divided by space: ");
// int [] inps = MyMethods.GetArrayFromString(ReadLine()!);
// double[,] array = MyMethods.GetDoubleMatrixArray(inps[0], inps[1], inps[2], inps[3]);
// MyMethods.PrintMatrix(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Write("Input rows columns minimum and maximum divided by space: ");
// int [] inps = MyMethods.GetArrayFromString(ReadLine()!);
// int [,] arr = MyMethods.GetMatrixArray(inps[0], inps[1], inps[2], inps[3]);
// MyMethods.PrintMatrix(arr);
// Write("Input row and column  divaded by space : ");
// inps = MyMethods.GetArrayFromString(ReadLine()!);
// if (MyMethods.IfIndexInArray(arr, inps[0], inps[1]))
// {
//     WriteLine($"--> {arr[inps[0], inps[1]]}");
// } else WriteLine("--> no such element");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Write("Input rows columns minimum and maximum divided by space: ");
int [] inps2 = MyMethods.GetArrayFromString(ReadLine()!);
int [,] arr2 = MyMethods.GetMatrixArray(inps2[0], inps2[1], inps2[2], inps2[3]);
MyMethods.PrintMatrix(arr2);
double [] result = new double [inps2[1]];
for (int i = 0;  i < inps2[1]; i++){
    for (int j = 0; j < inps2[0]; j++)
    {
        result[i] += arr2[j,i];
    }
    result[i] = result[i]/inps2[0];
}
WriteLine();
MyMethods.PrintMatrix(result);
