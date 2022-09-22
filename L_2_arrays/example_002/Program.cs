using static System.Console;
Clear();

// Write("input number :");
// int number = Convert.ToInt32(ReadLine());

// int i = 0;
// string result = "";
// while(i < number){
//     i++;
//     int sq_r = i*i;
//     result += Convert.ToString(sq_r) + ", ";
// }
// WriteLine(result);


Write("input day :");
int day = Convert.ToInt32(ReadLine());
string result = "";


// switch(day){
//     case 1:
//         result = "Monday";
//         break;
//     case 2: 
//         result = "Tuesday";
//         break;    
//     case 3: 
//         result = "Wednesday";
//         break;    
//     case 4: 
//         result = "Thursday";
//         break;    
//     case 5: 
//         result = "Friday";
//         break;    
//     case 6: 
//         result = "Saturday";
//         break;    
//     case 7: 
//         result = "Sunday";
//         break;
//     default:
//         result = "Not a weekday";
//         break;        
//     } 
// WriteLine(result);


string [] weekdays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
try {WriteLine(weekdays[day-1]);}
catch{WriteLine("Not a weekday");} 


//Два стрелка стреляют по банкам, первый - слева-направо, второй - справа - налево
//в какой-то момент они простреливают одну банку, каждый знает сколько он прострелил,
//вычислить кто сколько не поразил.

// Write("input shooter 1 :");
// int sht1 = Convert.ToInt32(ReadLine());
// Write("input shooter 2 :");
// int sht2 = Convert.ToInt32(ReadLine());
// WriteLine($"shooter 1 didn't shoot {sht2 - 1}");
// WriteLine($"shooter 2 didn't shoot {sht1 - 1}");

//3 человека делают кораблики  дев в 2р быстрее чем маль, вычислить сколько сделал каждый

WriteLine("");
Write("input ships :");
int ships = Convert.ToInt32(ReadLine());
if(ships%6 != 0){
    WriteLine("incorrect input");
    return;    
}
WriteLine($"girl - {ships/3*2}, boy - {ships/6}"); 

