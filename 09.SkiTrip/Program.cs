int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string feedback = Console.ReadLine();

double roomForOne = 18.00;
double apartment = 25.00;
double presidentApartment = 35.00;
double finalPrice = 0.0;
double night = days - 1;

switch (roomType)
{
    case "room for one person":
        finalPrice = night * roomForOne;
        break;
    case "apartment":
        finalPrice = night * apartment;

        if (days < 10)
        {
            finalPrice *= 0.70;
        }
        else if (days > 10 && days < 15)
        {
            finalPrice *= 0.65;
        }
        else if (days > 15)
        {
            finalPrice *= 0.50;
        }
        break;
    case "president apartment":
        finalPrice = night * presidentApartment;

        if (days < 10)
        {
            finalPrice *= 0.90;
        }
        else if (days > 10 && days < 15)
        {
            finalPrice *= 0.85;
        }
        else if (days > 15)
        {
            finalPrice *= 0.80;
        }
        break;
}
if (feedback == "positive")
{
    finalPrice *= 1.25;
}
else if (feedback == "negative")
{
    finalPrice *= 0.9;
}
Console.WriteLine($"{finalPrice:f2}");
    