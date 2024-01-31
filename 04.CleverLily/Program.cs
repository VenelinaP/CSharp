int age = int.Parse(Console.ReadLine());
double washerPrice = double.Parse(Console.ReadLine());
double pricePerToy = double.Parse(Console.ReadLine());

double money = 0.0;
double moneyGiven = 10.0;

for (int birthday = 1; birthday <= age; birthday++)
{
    if (birthday % 2 == 0)
    {
        money += moneyGiven - 1;
        moneyGiven += 10;
    }
    else
    {
        money += pricePerToy;
    }
}
if (money >= washerPrice)
{
    double moneyLeft = money - washerPrice;
    Console.WriteLine($"Yes! {moneyLeft:f2}");
}
else
{
    double moneyNeeded = washerPrice - money;
    Console.WriteLine($"No! {moneyNeeded:f2}");
}



