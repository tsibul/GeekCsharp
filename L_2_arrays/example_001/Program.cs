using static System.Console;
Clear();
Write("input x :");
int x = Convert.ToInt32(ReadLine()!);
Write("input y :");
int y = Convert.ToInt32(ReadLine()!);


if (x == 0 || y == 0)
{
    WriteLine(" на линии координат");
    return;
}
if (x > 0 && y > 0)
{
    WriteLine("1");
    return;
};
if (x < 0 && y > 0)
{
    WriteLine("2");
    return;
};
if (x < 0 && y < 0)
{
    WriteLine("3");
    return;
};
if (x > 0 && y < 0)
{
    WriteLine("4");
    return;
};
