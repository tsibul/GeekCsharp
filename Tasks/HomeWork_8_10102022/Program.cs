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
WriteLine("sorting rows");
MyMethods.PrintMatrix(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//MinSumOfRowElements(array);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Write("For multiple Matrix input rows, columns, minValue, maxValue split by space: ");
string prms21 = ReadLine();
int[] input21 = MyMethods.GetArrayFromString(prms21);
int[,] array21 = MyMethods.GetMatrixArray(input21[0], input21[1], input21[2], input21[3]);
MyMethods.PrintMatrix(array21);
WriteLine();

Write("For multiple Matrix for second matrix input rows, columns, minValue, maxValue split by space: ");
string prms22 = ReadLine();
int [] input22 = MyMethods.GetArrayFromString(prms22);
int[,] array22 = MyMethods.GetMatrixArray(input22[0], input22[1], input22[2], input22[3]);
MyMethods.PrintMatrix(array22);
WriteLine();
int[,] newarray2 = MatrixMultiplication(array21, array22);
MyMethods.PrintMatrix(newarray2);
WriteLine();


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Write("For 3D Array - input rows, columns, depth minValue, maxValue split by space: ");
string prms3 = ReadLine();
int[] input3 = MyMethods.GetArrayFromString(prms3);

int [] linearray3 = new int [input3[0]*input3[1]*input3[2]];
linearray3 = MyMethods.NotRepeatRandomArray(linearray3.Length, input3[3], input3[4]);
MyMethods.PrintMatrix(linearray3);
WriteLine();
WriteLine();

int [,,] newarray3 = Get3DArrayFromLine(linearray3, input3[0], input3[1] ,input3[2]);
WriteLine();


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Write("For Snail - input rows, columns split by space: ");
string prms4 = ReadLine();
int[] input4 = MyMethods.GetArrayFromString(prms4);
int[,] array4 = new int[input4[0], input4[1]];
ArrayFillSnail(array4);
MyMethods.PrintMatrix(array4);



//Methods

void ArrayFillSnail(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    arr[0, 0] = 1;
    int i = 0;
    int j = 0;
    string direction = "right";
    int k = 1;
    while (k <= rows * columns)
    {
        if (direction == "right")
        {
            j++;
            if (j < columns)
            {
                if (arr[i, j] == 0)
                {
                    arr[i, j] = k + 1;
                    k++;
                    continue;
                }
                else
                {
                    direction = "bottom";
                    j = j - 1;
                }
            }

            else
            {
                direction = "bottom";
                j = j - 1;
            }
        }
        if (direction == "bottom")
        {
            i++;
            if (i < rows)
            {
                if (arr[i, j] == 0)
                {
                    arr[i, j] = k + 1;
                    k++;
                    continue;
                }
                else
                {
                    direction = "left";
                    i = i - 1;
                }
            }
            else
            {
                direction = "left";
                i = i - 1;
            }
        }
        if (direction == "left")
        {
            j--;
            if (j >= 0)
            {
                if (arr[i, j] == 0)
                {
                    arr[i, j] = k + 1;
                    k++;
                    continue;
                }
                else
                {
                    direction = "up";
                    j = j + 1;
                }
            }

            else
            {
                direction = "up";
                j = j + 1;
            }
        }
        if (direction == "up")
        {
            i--;
            if (i >= 0)
            {
                if (arr[i, j] == 0)
                {
                    arr[i, j] = k + 1;
                    k++;
                    continue;
                }
                else
                {
                    direction = "right";
                    i = i + 1;
                }
            }
            else
            {
                direction = "right";
                i = i + 1;
            }
        }
        if(k == rows * columns) break;
    }
}



int[,,] Get3DArrayFromLine(int[] linearr, int rows, int columns, int depth)
{
    if (linearr.Length != rows * columns * depth)
    {
        WriteLine("incorrect dimensions");
        int[,,] err = new int[1, 1, 1];
        return err;
    }
    int[,,] newarr = new int[rows, columns, depth];
    int l = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                newarr[i, j, k] = linearr[l];
                Write($"{newarr[i, j, k]} ({i}, {j}, {k})\t");
                l++;
            }
            WriteLine();
        }
        WriteLine($"layer {i + 1} ↑");

    }
    return newarr;
}


int[,] MatrixMultiplication(int[,] arr, int[,] arr2)
{
    if (arr.GetLength(1) != arr2.GetLength(0))
    {
        WriteLine("imposible");
        int[,] err = new int[1, 1];
        return err;
    }
    int rows = arr.GetLength(0);
    int columns = arr2.GetLength(1);
    int intermediate = arr.GetLength(1);
    int[,] newarr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int r = 0; r < intermediate; r++)
            {
                newarr[i, j] += arr[i, r] * arr2[r, j];
            }
        }
    }
    return newarr;
}


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