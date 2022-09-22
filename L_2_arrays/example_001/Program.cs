using static System.Console;
Clear();
// Write("input x :");
// int x = Convert.ToInt32(ReadLine()!);
// Write("input y :");
// int y = Convert.ToInt32(ReadLine()!);


// if (x == 0 || y == 0)
// {
//     WriteLine(" на линии координат");
//     return;
// }
// if (x > 0 && y > 0)
// {
//     WriteLine("1");
//     return;
// };
// if (x < 0 && y > 0)
// {
//     WriteLine("2");
//     return;
// };
// if (x < 0 && y < 0)
// {
//     WriteLine("3");
//     return;
// };
// if (x > 0 && y < 0)
// {
//     WriteLine("4");
//     return;
// };


WriteLine("first point");
Write("input x1 :");
double x1 = Convert.ToDouble(ReadLine()!);
Write("input y1 :");
double y1 = Convert.ToDouble(ReadLine()!);
WriteLine("");
WriteLine("second point");
Write("input x2 :");
double x2 = Convert.ToDouble(ReadLine()!);
Write("input y2 :");
double y2 = Convert.ToDouble(ReadLine()!);
double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
WriteLine($"distance between ({x1},{y1}) and ({x2},{y2}) = {result}");
