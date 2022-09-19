using static System.Console;
Clear();

int number = new Random().Next(100, 999+1);
WriteLine($"number = {number}");
int n0 = number%10;
int n2 = number/100;
WriteLine($"{n2}{n0}");
WriteLine($"result = {n2*10+n0}");