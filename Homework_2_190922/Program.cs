using static System.Console;
Clear();

WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число");
WriteLine("и на выходе показывает вторую цифру этого числа.");
WriteLine("");

int number = new Random().Next(100, 999+1);
WriteLine($"number = {number}");
int result = number/10%10;
WriteLine($"second digit = {result}");

WriteLine("");
WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день"); 
WriteLine("недели, и проверяет, является ли этот день выходным.");
WriteLine("");

Write("input weekday No: ");
int weekday = int.Parse(ReadLine()!);
string message = weekday==7||weekday==6? "Yes" : weekday>0&&weekday<6? "No": $"{weekday} not a weekday number!";
WriteLine(message);

WriteLine("");
WriteLine("Задача 13: Напишите программу, которая выводит третью цифру"); 
WriteLine("заданного числа или сообщает, что третьей цифры нет.");
WriteLine(""); 