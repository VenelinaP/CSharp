double budget = double.Parse(Console.ReadLine());
int extras = int.Parse(Console.ReadLine()); //extras - статисти
double clothesPricePerExta = double.Parse(Console.ReadLine());

double decor = 0.1 * budget; 
double totalClothes = extras * clothesPricePerExta; 

if (extras > 150)
{
  totalClothes *= 0.9;
}

double filmPrice = totalClothes + decor;

if (budget >= filmPrice) 
{
    double moneyLeft = budget - filmPrice;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
}
else
{
    double moneyNeeded = filmPrice - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
}



