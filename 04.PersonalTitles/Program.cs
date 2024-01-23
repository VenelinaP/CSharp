double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine()); //в char може да се пише само един символ

if (age >= 16)
{
    if (gender == 'm')
    {
        Console.WriteLine("Mr.");
    }
    else if (gender == 'f')
    {
        Console.WriteLine("Ms.");
    }
}
else
{
    if (gender == 'm')
    {
        Console.WriteLine("Master");
    }
    else if (gender == 'f')
    {
        Console.WriteLine("Miss");
    }
}