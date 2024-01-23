int time = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

if (time >= 10 && time < 18)
{
    if (day == "Monday")
    {
        Console.WriteLine("open");
    }
    else if (day == "Tuesday")
    {
        Console.WriteLine("open");
    }
    else if (day == "Wednesday")
    {
        Console.WriteLine("open");
    }
    else if (day == "Thursday")
    {
        Console.WriteLine("open");
    }
    else if (day == "Friday")
    {
        Console.WriteLine("open");
    }
    else if (day == "Saturday")
    {
        Console.WriteLine("open");
    }    
}
else
{
    Console.WriteLine("closed");
}



