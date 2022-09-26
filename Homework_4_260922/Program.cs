using static System.Console;
Clear();

//Task 25

// Write ("input A : ");
// int A = Convert.ToInt32(ReadLine()!);
// Write ("input B : ");
// int B = Convert.ToInt32(ReadLine()!);
// WriteLine($"{A}^{B}={GetNaturalPower(A, B)}");

//Task 27

Write ("input number : ");
int numb1 = Convert.ToInt32(ReadLine()!);
WriteLine($"Sum of digits {numb1} = {GetSumDigits(numb1)}");




//Methods

// Решение через отдельные методы
// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNaturalPower(int num1, int num2){
    if(num2 <= 0){
        return -1;
    } 
    int power = 1;
    int i = 1;
    while(i <= num2){
        power *= num1;
        i++;
    }
    return power;
}

// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumDigits(int number){
    int result = 0;
    while(number>0){
        result += number%10;
        number /= 10;
    }
    return result;
}

// Задача 29: Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33]