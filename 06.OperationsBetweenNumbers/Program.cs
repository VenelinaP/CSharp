int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char c = char.Parse(Console.ReadLine());

double result = 0.0;

if (c == '+' || c == '-' || c =='*')
{
    switch (c)
    {
        case '+':
            result = n1 + n2;
            break;
        case '-':
            result = n1 - n2;
            break;
        case '*':
            result = n1 * n2;
            break;
    }if (result % 2 == 0)
    {
        Console.WriteLine($"{n1} {c} {n2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{n1} {c} {n2} = {result} - odd");
    }

}
else if (c == '/')
{
    if (n2 == 0)
    {
        Console.WriteLine($"Cannot divide {n1} by zero");
    }
    else
    {
        result = (double)n1 / n2;
        Console.WriteLine($"{n1} / {n2} = {result:f2}");
    }
}
else if (c == '%')
{
    if (n2 == 0)
    {
        Console.WriteLine($"Cannot divide {n1} by zero");
    }
    else
    {
        result = n1 % n2;
        Console.WriteLine($"{n1} % {n2} = {result}");
    }
}


