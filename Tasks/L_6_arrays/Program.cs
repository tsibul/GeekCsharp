using static System.Console;
using GeekLib;
Clear();

Write("input rows, columns, minValue, maxValue split by space: ");
string prms = ReadLine();
int[] input = MyMethods.GetArrayFromString(prms);
int[,] array = MyMethods.GetMatrixArray(input[0], input[1], input[2], input[3]);

MyMethods.PrintMatrix(array);
WriteLine();

int[,] newarray = DeleteRowColumn(array);
MyMethods.PrintMatrix(newarray);



//Methods
void ReplaceRows1End(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int tmp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = tmp;
    }
}


string TransponMatrix(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        return "couldn't do";
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            int tmp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = tmp;
        }
    }
    return "ready";

}

int[,] TransponToNewMatrix(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        WriteLine("couldn't do");
        return arr;
    }
    int[,] newarr = new int[arr.GetLength(0), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(0); j++)
        {
            newarr[i, j] = arr[j, i];
        }
    }
    WriteLine("ready");
    return newarr;

}

int[] linearray(int[,] arr)
{
    int[] linearr = new int[arr.GetLength(0) * arr.GetLength(1)];
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            linearr[k] = arr[i, j];
            k++;
        }
    }
    Array.Sort(linearr);
    return linearr;
}

void FreqInt(int[] array)
{
    int tmp = array[0];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == tmp)
        {
            k++;
        }
        else
        {
            WriteLine($"freq of {tmp} is {k}");
            k = 1;
            tmp = array[i];
        }
    }
    WriteLine($"freq of {tmp} is {k}");
}

int[,] DeleteRowColumn(int[,] array)
{
    int minimum = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minimum > array[i, j])
            {
                minimum = array[i, j];
                row = i;
                column = j;
            }
        }
    }
    WriteLine($"{row} {column} {minimum}");
    WriteLine();
    int ki = 0;
    int kj = 0;
    int[,] newarray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        if (i == column) ki = ki + 1;
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            if (j == row) kj = kj + 1;
            newarray[i, j] = array[ki, kj];
            kj++;
        }
        ki++;
        kj = 0;

    }
    return newarray;
}




// **Задача 53:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// апример, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2


// *Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// **Задача 5**. Заполните спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

