using static System.Console;
Clear();

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Write("input 5 digits number :");
int num5 = Convert.ToInt32(ReadLine());
if(num5 >= 100000 || num5 < 10000){
    WriteLine($"{num5} is not 5 digits number");
    return;
}
int i = 0;
int num5_reverse = 0;
int num5_ = num5;
string result = "No";
while (i < 5){
    i++;
    num5_reverse = num5_reverse*10 + num5_%10;
    num5_ = num5_/10;
}
if(num5 == num5_reverse){
    result = "Yes";
}
WriteLine(result);
WriteLine("");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// !!!! если первое число не 5-значное сюда не дойдет из-за return
WriteLine("first point");
Write("input x1 :");
double x1 = Convert.ToDouble(ReadLine());
Write("input y1 :");
double y1 = Convert.ToDouble(ReadLine());
Write("input z1 :");
double z1 = Convert.ToDouble(ReadLine());
WriteLine("");
WriteLine("second point");
Write("input x2 :");
double x2 = Convert.ToDouble(ReadLine());
Write("input y2 :");
double y2 = Convert.ToDouble(ReadLine());
Write("input z2 :");
double z2 = Convert.ToDouble(ReadLine());
double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
WriteLine("");
WriteLine($"distance between ({x1},{y1},{z1}) and ({x2},{y2},{z2}) = {distance:f2}");

WriteLine("");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Write("input N :");
int num = Convert.ToInt32(ReadLine());

i = 1;
string pow3 = "1";
int [] pw3 = new int[num];
pw3 [0] = 1;
while(i < num){
    i++;
    int pw_3 = i*i*i;
    pow3 += ", " + Convert.ToString(pw_3);
    pw3 [i-1] = pw_3;

}
WriteLine(pow3);
foreach(var item in pw3)
{
    Console.Write(item.ToString() + " ");
};

