using static System.Console;

Clear();
Write("input number:");
int num1 = Convert.ToInt32(ReadLine());
string date_name = "";
if(num1==1){
    date_name = "Monday";}
if(num1==2){
    date_name = "Tuesday";}
if(num1==3){
    date_name = "Wednesday";}
if(num1==4){
    date_name = "Thursday";}
if(num1==5){
    date_name = "Friday";}
if(num1==6){
    date_name = "Saturday";}
if(num1==7)
{
    date_name = "Sunday";
}
if(num1<1 | num1>7){
    date_name = "такого не бывает";
}
Write($"weekday of {num1} is {date_name}");