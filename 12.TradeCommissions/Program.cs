string town = Console.ReadLine();
double salesVolume = double.Parse(Console.ReadLine());

double brokerProfit = 0;

if (town == "Sofia")
{
    if (salesVolume > 0 && salesVolume <= 500)
    {
        brokerProfit = salesVolume * 0.05;
    }
    else if (salesVolume > 500 && salesVolume <= 1000)
    {
        brokerProfit = salesVolume * 0.07;
    }
    else if (salesVolume > 1000 && salesVolume <= 10000)
    {
        brokerProfit = salesVolume * 0.08;
    }
    else if (salesVolume > 10000)
    {
        brokerProfit = salesVolume * 0.12;
    }
    else Console.WriteLine("error");
}
else if (town == "Varna")
{
    if (salesVolume > 0 && salesVolume <= 500)
    {
        brokerProfit = salesVolume * 0.045;
    }
    else if (salesVolume > 500 && salesVolume <= 1000)
    {
        brokerProfit = salesVolume * 0.075;
    }
    else if (salesVolume > 1000 && salesVolume <= 10000)
    {
        brokerProfit = salesVolume * 0.10;
    }
    else if (salesVolume > 10000)
    {
        brokerProfit = salesVolume * 0.13;
    }
    else Console.WriteLine("error");
}
else if (town == "Plovdiv")
{
    if (salesVolume > 0 && salesVolume <= 500)
    {
        brokerProfit = salesVolume * 0.055;
    }
    else if (salesVolume > 500 && salesVolume <= 1000)
    {
        brokerProfit = salesVolume * 0.08;
    }
    else if (salesVolume > 1000 && salesVolume <= 10000)
    {
        brokerProfit = salesVolume * 0.12;
    }
    else if (salesVolume > 10000)
    {
        brokerProfit = salesVolume * 0.145;
    }
    else Console.WriteLine("error");
}
else
{
    Console.WriteLine("error");
}

if (brokerProfit > 0)
{
    Console.WriteLine($"{brokerProfit:F2}");
}