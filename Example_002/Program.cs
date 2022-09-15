using static System.Console;

Clear();
Write("input number:");
int num1 = Convert.ToInt32(ReadLine());
int num2 = int.Parse(ReadLine()!);
int sqr2 = Convert.ToInt32(Math.Pow(num2,2));
if(num1 == sqr2){
WriteLine($"sqr of number {num2} = {sqr2} Yes!!!!");
}
else{
WriteLine($"sqr of number {num2} != {sqr2} NO!!!!");
}

