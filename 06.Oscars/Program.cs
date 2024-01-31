string name = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int jury = int.Parse(Console.ReadLine());

double pointsGiven = 0.0;

for (int i = 0; i < jury; i++) //В цикъл се чете името и точките на всeки от оценяващите.
                               //За всяко име на оценяващ се пресмятат точките спрямо дължината на името и точките, които дава.
                               //Tези точки се добавят към общите точки juryPoints.
{
    string juryName = Console.ReadLine();
    double juryPoints = double.Parse(Console.ReadLine());
    
    if (i == 0)
    {
        pointsGiven = academyPoints + juryName.Length * juryPoints / 2;
    }
    else
    {
        pointsGiven += ((juryName.Length * juryPoints) / 2);
    }
    if (pointsGiven >= 1250.5)
    {
        break;
    }
}
if (pointsGiven >= 1250.5)
{
    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {pointsGiven:f1}!");
}
else if (pointsGiven < 1250.5)
{
    Console.WriteLine($"Sorry, {name} you need {1250.5 - pointsGiven:f1} more!");
}

