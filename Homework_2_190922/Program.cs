using static System.Console;
Clear();

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 999+1);
WriteLine($"number = {number}");
int result = number/10%10;
WriteLine($"second digit = {result}");