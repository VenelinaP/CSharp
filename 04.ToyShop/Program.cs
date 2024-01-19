double excursionPrice = double.Parse(Console.ReadLine());
int puzzelsCount = int.Parse(Console.ReadLine());
int dollsCount = int.Parse(Console.ReadLine());
int bearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());

// Цени на играчките
double puzzlePrice = 2.60;
double dollPrice = 3.00;
double bearPrice = 4.10;
double minionPrice = 8.20;
double truckPrice = 2.00;

// Изчисляване на общата цена на играчките
double toysPrice = puzzelsCount * puzzlePrice + dollsCount * dollPrice + bearsCount * bearPrice +
                  minionsCount * minionPrice + trucksCount * truckPrice;

// Изчисляване на общия брой играчки
int totalToysCount = puzzelsCount + dollsCount + bearsCount + minionsCount + trucksCount;

// Проверка за отстъпка
if (totalToysCount >= 50)
{
    double discount = toysPrice * 0.25;
    toysPrice -= discount;
}

// Изчисляване на наема на магазина
double rent = toysPrice * 0.1;

// Крайна цена и печалба
double finalPrice = toysPrice - rent;
double neededMoney = Math.Abs(finalPrice - excursionPrice);

// Извеждане на резултата
if (finalPrice >= excursionPrice)
{
    Console.WriteLine($"Yes! {neededMoney:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
}


   
 