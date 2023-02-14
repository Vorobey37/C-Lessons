Console.Clear();
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
int a1 = new Random ().Next(-100, 100);
int a2 = new Random ().Next(-100, 100);
int a3 = new Random ().Next(-100, 100);
int b1 = new Random ().Next(-100, 100);
int b2 = new Random ().Next(-100, 100);
int b3 = new Random ().Next(-100, 100);
int c1 = new Random ().Next(-100, 100);
int c2 = new Random ().Next(-100, 100);
int c3 = new Random ().Next(-100, 100);
int max1 = Max(a1, a2, a3);
int max2 = Max(b1, b2, b3);
int max3 = Max(c1, c2, c3);
int max = Max(max1, max2, max3);
/*Или можно сделать так:
int max = Max(
    Max(a1, a2, a3), 
    Max(a1, a2, a3), 
    Max(a1, a2, a3));
*/
Console.WriteLine(max);
Console.Write($"{a1}, {a2}, {a3}, {b1}, {b2}, {b3}, {c1}, {c2}, {c3}");

