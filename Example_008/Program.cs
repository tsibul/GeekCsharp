using static System.Console;
Clear();

int number = new Random().Next(100, 999+1);
WriteLine($"number = {number}");
int n0 = number%10;
int n2 = number/100;
int n1 = (number - n2*100)/10;
WriteLine($"{n0}{n1}{n2}");
//WriteLine($"result = {n0*100+n1*10+n2}");

Write("input number 2:");
string num2 = ReadLine();
int n = num2.Length;
int num2 = int.Parse(num2);
int i=0;
while(i<n){
    
}
