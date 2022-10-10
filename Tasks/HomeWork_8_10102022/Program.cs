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
SortRowElements(array);
MyMethods.PrintMatrix(array);


//Methods

int [] RowFromMatrix(int [,] arr, int rownumber){
    int [] newarr = new int [arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        newarr[i] = arr[rownumber,i];
    }
    return newarr;
}

void SortRowElements(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int [] newarr = RowFromMatrix(arr, i);
        Array.Sort(newarr);
        MyMethods.ReverseArraySelf(newarr);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = newarr[j];
        }
    }
}