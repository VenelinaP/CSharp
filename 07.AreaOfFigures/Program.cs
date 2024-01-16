string figure = Console.ReadLine();
double num = double.Parse(Console.ReadLine());

if (figure == "square")
{
    double area = num * num;
    Console.WriteLine($"{area:F3}");
}
else if (figure == "rectangle")
{
    double b = double.Parse(Console.ReadLine());
    double area = num * b;
    Console.WriteLine($"{area:F3}");
}
else if (figure == "circle")
{
    double area = num * num * Math.PI;
    Console.WriteLine($"{area:F3}");
}
else 
{
    double hA = double.Parse(Console.ReadLine());
    double area = num * hA / 2;
    Console.WriteLine($"{area:F3}");
}