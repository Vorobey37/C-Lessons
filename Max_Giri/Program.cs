int a = new Random().Next(-100,100);
int b = new Random().Next(-100,100);
int c = new Random().Next(-100,100);
int d = new Random().Next(-100,100);
int e = new Random().Next(-100,100);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);

int max = a;

if(b>max) 
{
max=b;
}

if(c>max) 
{
    max=c;
}

if(d>max)
{
max=d;
}
if(e>max)
{
max=e;
}
Console.Write("Максимальное число - это ");
Console.WriteLine(max);
