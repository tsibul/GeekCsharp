using static System.Console;
Clear();

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] arr = PrepareArray();
//WriteLine($"number of evens - {GetEvens(arr)}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

WriteLine($"sum of even places (odd indexes) - {SumOfEvenIndexes(arr)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76




// Methods
int SumOfEvenIndexes(int [] arr){
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 == 1) res += arr[i];
    }
    return res;
}


int GetEvens(int [] arr){
    int res = 0;
    foreach (var item in arr)
    {
        if (item%2 == 0) res++;
    }
    return res;
}

int [] PrepareArray(){
    Write(" array size: ");
    int len = Convert.ToInt32(ReadLine()!);
    Write(" array min: ");
    int minimal = Convert.ToInt32(ReadLine()!);
    Write(" array max: ");
    int maximal = Convert.ToInt32(ReadLine()!);
    int [] arr = GetArray(len, minimal, maximal);
    WriteLine($"[{String.Join(", ", arr)}]");
    return arr;
} 

int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1);
    }
    return result;
}
