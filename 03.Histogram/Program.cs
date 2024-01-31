double n = double.Parse(Console.ReadLine());

int c1 = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;

for (int i = 1;  i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num < 200)
    {
        c1++;
    }
    else if (num <= 399)
    {
        c2++;
    }
    else if (num <= 599)
    {
        c3++;
    }
    else if (num <= 799)
    {
        c4++;
    }
    else
    {
        c5++;
    } 
}
double p1 = (c1 / n) * 100;
double p2 = (c2 / n) * 100;
double p3 = (c3 / n) * 100;
double p4 = (c4 / n) * 100;
double p5 = (c5 / n) * 100;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");