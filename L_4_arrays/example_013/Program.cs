using static System.Console;
Clear();

// **Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество 
//элементов массива, значения которых лежат в отрезке [10,99].
// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Write(" array size: ");
int len = Convert.ToInt32(ReadLine()!);
Write(" array min: ");
int minimal = Convert.ToInt32(ReadLine()!);
Write(" array max: ");
int maximal = Convert.ToInt32(ReadLine()!);
int [] arr = GetArray(len, minimal, maximal);
WriteLine($"[{String.Join(", ", arr)}]");

Write(" diapason starts: ");
int start = Convert.ToInt32(ReadLine()!);
Write(" diapason end: ");
int end = Convert.ToInt32(ReadLine()!);
WriteLine($"between {start} and {end} = {LookFor(arr, start, end)} ");




// **Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//int [] res = MultElement(arr);
//WriteLine($"[{String.Join(", ", res)}]");



//Methods

int LookFor(int [] array, int startwith, int endwith){
    int count = 0;
    foreach (var itm in array)
    {
        if(itm >= startwith && itm <= endwith){count++;}
    }
    return count;
}

int [] MultElement(int [] array){
    int len = array.Length;
    int size = len/2 + len%2;
    int [] multarray = new int [size];
    for(int i=0; i < size; i++){
        if (i != len - 1 - i)
        {
        multarray[i] = array[i] * array[len - 1 - i];            
        }
        else{multarray[i] = array[i];}
    }
    return multarray;
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

