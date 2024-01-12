int chickenMenuesQty = int.Parse(Console.ReadLine());
int fishMenuesQty = int.Parse(Console.ReadLine());
int vegieMenuesQty = int.Parse(Console.ReadLine());

double chickenMenues = 10.35;
double fishMenues = 12.40;
double vegieMenues = 8.15;

double chickenMenuesPrice = chickenMenues * chickenMenuesQty;
double fishMenuesPrice = fishMenues * fishMenuesQty;
double vegieMenuesPrice = vegieMenues * vegieMenuesQty;

double totalPrice = chickenMenuesPrice + fishMenuesPrice + vegieMenuesPrice;
double desert = totalPrice * 0.2;
double delivery = 2.50;

Console.WriteLine(totalPrice + desert + delivery);
