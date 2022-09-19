using static System.Console;

Clear();
Write("input number 1:");
int num1 = Convert.ToInt32(ReadLine());
Write("input number 2:");
int num2 = Convert.ToInt32(ReadLine());
WriteLine($"{num1} - {num2}");
if(num2%num1 == 0){
    WriteLine($"{num2} кратно {num1}");
}
else{
    WriteLine($"остаток от деления {num2} на {num1} = {num2%num1}");
}