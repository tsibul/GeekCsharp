using static System.Console;
Clear();

//**Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Write(" =:");
// int n = Convert.ToInt32(ReadLine()!);
// int [] Fibonacci = new int [n];
// Fibonacci[0] = 0;
// Fibonacci[1] = 1;
// for (int i = 2; i < n; i++)
// {
//     Fibonacci[i] = Fibonacci[i-1] + Fibonacci[i-2];
// }
// WriteLine(Fibonacci[n-1]);
// WriteLine($"[{String.Join(", ", Fibonacci)}]");

//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [] array = PrepareArray();
    int [] result = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
       result [i] = array[i]; 
    }
WriteLine($"[{String.Join(", ", array)}]");



// int [] arr = PrepareArray();
// WriteLine($"[{String.Join(", ", ReverseArray(arr))}]");
// ReverseArray2(arr);
// WriteLine($"[{String.Join(", ", arr)}]");


//Methods
void ReverseArray2(int [] array){
    for (int i = 0; i < array.Length/2; i++)
    {
       int temp = array[i]; 
       array[i] = array[array.Length - 1 - i];
       array[array.Length - 1 - i] = temp;
    }
}


int [] ReverseArray(int [] array){
    int [] result = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
       result [i] = array[array.Length - 1 - i]; 
    }
    return result;
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



int [] PrepareArray(){
    Write(" array size, min, max: ");
    string [] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int [] arr = GetArray(Convert.ToInt32(parameters[0]),Convert.ToInt32(parameters[1]), Convert.ToInt32(parameters[2]));
    WriteLine($"[{String.Join(", ", arr)}]");
    return arr;
} 