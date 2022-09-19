using static System.Console;
Clear();

WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число");
WriteLine("и на выходе показывает вторую цифру этого числа.");
WriteLine("");

int number = new Random().Next(100, 999 + 1);
WriteLine($"number = {number}");
int result = number / 10 % 10;
WriteLine($"second digit = {result}");

WriteLine("");
WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день");
WriteLine("недели, и проверяет, является ли этот день выходным.");
WriteLine("");

Write("input weekday No: ");
int weekday = int.Parse(ReadLine()!);
string message = weekday == 7 || weekday == 6 ? "Yes" : weekday > 0 && weekday < 6 ? "No" : $"{weekday} not a weekday number!";
WriteLine(message);

WriteLine("");
WriteLine("Задача 13: Напишите программу, которая выводит третью цифру");
WriteLine("заданного числа или сообщает, что третьей цифры нет.");
WriteLine("");

Write("input number: ");
string random_input = ReadLine();
int num_len = random_input.Length;
int random_number = int.Parse(random_input);
//string third_digit = "No third digit";
//if (num_len > 2)
//{
//    int third = random_number / Convert.ToInt32(Math.Pow(10, num_len - 3)) % 10;
//    third_digit = $"third_digit = {third}";
//}

//WriteLine(third_digit + " not work for long numbers");

int rdm = random_number;
int thrd = 0;
while (rdm != 0){
    thrd = thrd*10 + rdm%10;
    rdm = rdm/10;
}
string third_digit = thrd/100%10==0?"no third digit":$"third digit {thrd/100%10}";
WriteLine(third_digit);
