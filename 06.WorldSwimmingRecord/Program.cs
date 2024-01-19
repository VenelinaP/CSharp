double currRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double secondsPerMeter = double.Parse(Console.ReadLine());

double timeInSeconds = secondsPerMeter * distance;
double ivanDistance = Math.Floor(distance / 15) * 12.5;
double ivanTime = timeInSeconds + ivanDistance;
double timeLeft = ivanTime - currRecord;

if (ivanTime >= currRecord)
{
    Console.WriteLine($"No, he failed! He was {timeLeft:f2} seconds slower.");
}
else
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:f2} seconds.");
}

