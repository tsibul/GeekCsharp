using static System.Console;
Clear();

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Write("input No: ");
int num1 = Convert.ToInt32(ReadLine());
int mes = GetFactor(num1);
WriteLine($" result {mes}");



// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120


// Methods

int GetSum(int number){
    int result = 0;
    for (int i = 1; i <= number; i++){
        result += i;
    }
    return result;
}

int GetLen(int number){
    int result2 = 0;
    while(number>0){
        number /= 10;
        result2 ++;
    }
    return result2;
}

int GetFactor(int number){
    int result = 1;
    for(int i = 1; i <= number; i++){
        result *= i;
    }
    return result;
}


