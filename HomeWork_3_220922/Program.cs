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
