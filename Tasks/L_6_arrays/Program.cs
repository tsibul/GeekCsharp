using static  System.Console;
using GeekLib;
Clear();

int [] arr = MyMethods.PrepareRandomArray();


int count = 0;

do
{
    Write("Input number: ");
    if (int.Parse(ReadLine()!) > 0) count++;
    WriteLine($"Positive numbers = {count}");
    WriteLine("Continue? Yes - enter, No - any key");
} while (ReadKey().Key==ConsoleKey.Enter);
