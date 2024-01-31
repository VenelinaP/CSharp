int n = int.Parse(Console.ReadLine());
int points = int.Parse(Console.ReadLine());

int pointsWon = 0;
int tournamentWon = 0;

for (int tournament = 1; tournament <= n; tournament++)
    {
    string position = Console.ReadLine();
    if (position == "W")
    {
        pointsWon += 2000;
        tournamentWon++;
    }
    else if (position == "F")
    {
        pointsWon += 1200;
    }
    else if (position == "SF")
    {
        pointsWon += 720;
    }
}
Console.WriteLine($"Final points: {points + pointsWon}");

double averagePoints = pointsWon / n;
Console.WriteLine($"Average points: {averagePoints}" );

double percent = (tournamentWon / (double)n ) * 100;
Console.WriteLine($"{percent:F2}%");

