using System;
using static System.Console;
namespace GeekLib;
public class MyMethods
{
    public static int[] GetRandomArray(int size, int minValue, int maxValue)
    {
        Random rnd = new Random();
        int[] result = new int[size];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = rnd.Next(minValue, maxValue + 1);
        }
        return result;
    }

    public static int[] PrepareRandomArray()
    {
        Write("input array size, minValue, maxValue splited with spaces: ");
        string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] arr = GetRandomArray(Convert.ToInt32(parameters[0]), Convert.ToInt32(parameters[1]), Convert.ToInt32(parameters[2]));
        WriteLine($"[{String.Join(", ", arr)}]");
        return arr;

    }
    int[] ReverseArrayToNew(int[] array)
    {
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[array.Length - 1 - i];
        }
        return result;
    }

    void ReverseArraySelf(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }
    }

    int[] GetArrayFromString(string parameters)
    {
        string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] parameterNum = new int[parames.Length];
        for (int i = 0; i < parameterNum.Length; i++)
        {
            parameterNum[i] = int.Parse(parames[i]);
        }
        return parameterNum;
    }
    void PrintMatrix(int[,] inMatrix)
    {
        for (int i = 0; i < inMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inMatrix.GetLength(1); j++)
            {
                Write($"{inMatrix[i, j]} ");
            }
            WriteLine();
        }
    }
    int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
    {
        int[,] resultMatrix = new int[rows, columns];
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return resultMatrix;
    }



}
