using static  System.Console;
using GeekLib;
Clear();

Write("input number N: ");
int num1 = Convert.ToInt32(ReadLine());
Write("input number M: ");
int num2 = Convert.ToInt32(ReadLine());

// **Задача 65:** Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

//  string result = GetNumbersNM2(num1, num2);
//  Write(result);


// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

//Write(SumOfDigits(num1));


// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int result = PowerNM(num1, num2);
WriteLine(result);

result = FactorialN(num1);
Write(result);



//Methods
int PowerNM(int n, int m){
   return (m ==0)? 1 : PowerNM(n, m-1) * n; 
}

int FactorialN(int n){
   return (n ==0)? 1 : FactorialN(n-1) * n; 
}

// n^m = n * n^(m-1)

int SumOfDigits(int n){
    return (n/10 == 0) ? n%10 : SumOfDigits(n/10) + n%10;
}

//1234
// G(123) + 4
// G(12) + 3
// G(1) + 2
// 1
// 1 + 2 + 3 +4

string GetNumbersNM2(int n, int m)
{
    if (n == m)
    {
        return n.ToString();    
    }
    return (n > m) ? GetNumbersNM2(n - 1, m) + " " + n : GetNumbersNM2(m - 1, n) + " " + m;
}



string GetNumbers2(int n)
{
    return (n == 1) ? n.ToString() : GetNumbers2(n - 1) + " " + n;
}
