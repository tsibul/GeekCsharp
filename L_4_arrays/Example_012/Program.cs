using static System.Console;
Clear();

// **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Write(" array size: ");
int len = Convert.ToInt32(ReadLine()!);
Write(" array min: ");
int minimal = Convert.ToInt32(ReadLine()!);
Write(" array max: ");
int maximal = Convert.ToInt32(ReadLine()!);
int [] arr = GetArray(len, minimal, maximal);
WriteLine($"[{String.Join(", ", arr)}]");

// ChgToOpposite(arr);
// WriteLine($"[{String.Join(", ", arr)}]");

// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Write(" looking for : ");
int look = Convert.ToInt32(ReadLine()!);
WriteLine($"{LookUp(arr, look)}");
string answer = LookUpBool(arr, look)? "Yes": "No"; 
WriteLine($"{answer}");


//Metods
string LookUp (int [] array, int look_up)
{
    string result = "False";
    int count = 0;
    foreach (var item in array)
    {

        if (item == look_up)
        {
           result = "True";
           break;
        }
        count++;
    }
    return result + count;  
} 

bool LookUpBool (int [] array, int look_up)
{
    foreach (var item in array)
    {

        if (item == look_up)
        {
           return true;
        }
    }
    return false;  
} 

void ChgToOpposite(int [] arr){
    for(int i=0; i<arr.Length; i++){
        arr[i] = -arr[i];
    }
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


