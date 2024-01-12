int nylonQty = int.Parse(Console.ReadLine()); // Qty - съкратено quantity
int paintQty = int.Parse(Console.ReadLine());
int thinnerQty = int.Parse(Console.ReadLine());
int workHours = int.Parse(Console.ReadLine());

int extraNylonQty = 2;
int totalNylonQty = nylonQty + extraNylonQty;
double nylonPrice = totalNylonQty * 1.50;

double extraPaintQty = 0.1 * paintQty; 
double totalPaintQty = paintQty + extraPaintQty;
double paintPrice = totalPaintQty * 14.50;

int thinnerPrice = thinnerQty * 5;

double totalMaterialsPrice = nylonPrice + paintPrice + thinnerPrice + 0.40;
double workersPayPerHour = 0.3 * totalMaterialsPrice;
double totalWorkersPay = workHours * workersPayPerHour;

Console.WriteLine(totalMaterialsPrice + totalWorkersPay);



