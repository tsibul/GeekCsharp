using static System.Console;
Clear();

// input 3 numbers for all tasks
Write("input number 1: ");
int num1 = Convert.ToInt32(ReadLine());
Write("input number 2: ");
int num2 = Convert.ToInt32(ReadLine());
Write("input number 3: ");
int num3 = Convert.ToInt32(ReadLine());

//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.
//use num1 and num2

string comparison = $"first number ( {num1} ) more than second number ( {num2} )";
if(num1 < num2){
    comparison = $"first number ( {num1} ) less than second number ( {num2} )";
}
else if(num1==num2){
    comparison = $"both nambers ( {num1} ) are equal";
}
Write(comparison);

//Задача 4: Напишите программу, которая принимает 
//на вход три числа и выдаёт максимальное из этих чисел.
//use num1, num2, num3

comparison = $"maxiimum number from set ({num1}, {num2}, {num3}) third - {num3} ";
if(num1>=num2 & num1>=num3){
    comparison = $"maxiimum number from set ({num1}, {num2}, {num3}) first - {num1} ";
}
else if(num2 >= num1 & num2 >= num3){
    comparison = $"maxiimum number from set ({num1}, {num2}, {num3}) second - {num2} ";
}
Write(comparison);


