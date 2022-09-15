using static System.Console;

Clear();
Write("input number:");
int num1 = Convert.ToInt32(ReadLine());
int num2 = int.Parse(ReadLine()!);
int sqr1 = num1*num1;
int sqr2 = Convert.ToInt32(Math.Pow(num2,2));
WriteLine($"sqr of number {num1} = {sqr1}");
WriteLine($"sqr of number {num2} = {sqr2}");
