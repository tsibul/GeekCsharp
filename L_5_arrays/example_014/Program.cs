using static System.Console;
Clear();


//Задача 40: Напишите программу, которая принимает на вход три числа и 
///проверяет, может ли существовать треугольник с сторонами такой длины.

// WriteLine(" стороны a, b, c: ");
// string [] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int a = Convert.ToInt32(parameters[0]);
// int b = Convert.ToInt32(parameters[1]);
// int c = Convert.ToInt32(parameters[2]);
// string result = "не треугольник";
// if( a+b>c && b+c>a && a+c>b){
//     result = "треугольник";
// }
// WriteLine(result);

//Задача 42: Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное.
// WriteLine("введите число : ");
// int n10 = Convert.ToInt32(ReadLine()!);
// WriteLine("введите основание : ");
// int x = Convert.ToInt32(ReadLine()!);
// WriteLine($"N2 = {N10toNX(n10, x)}");

// Цвет клетки по координате
// Сумма координат четная - белая, нечетная - черная
WriteLine("введите букву : ");
string str  = ReadLine();
WriteLine("введите цифру : ");
int a = Convert.ToInt32(ReadLine()!);
string letters = "abcdefgh";
string result = "белая";
if((letters.IndexOf(str) + a)%2 == 0){
    result = "черная";    
}
WriteLine(result);


string DecToNum(int decNumber, int otherSystem)
{
    string res="";
    string nums="0123456789ABCDEF";
    while(decNumber>0)
    {
        int ost=decNumber/otherSystem;
       // res=nums[ost]+res;
        res=nums[decNumber-otherSystem*ost]+res;
        decNumber/=otherSystem;
    }
    return res;
}







string N10toNX (int n10, int x){
    string result = String.Empty;
    if (x >=10 && x <2 ){
        return "error";
    }
    if(n10==0){
        return "0";}    
    while(n10 > 0){
        result = n10%x + result;
        n10 = n10/x;
    }
    return result;
}



string N10toN2 (int n10){
    string result = String.Empty;
    if(n10==0){
        return "0";}    
    while(n10 > 0){
        result = n10%2 + result;
        n10 = n10/2;
    }
    return result;
}



//Methods
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