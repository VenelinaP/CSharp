string seriesTitle = Console.ReadLine();
int episodesDuration = int.Parse(Console.ReadLine());
int lunchBreakDuration = int.Parse(Console.ReadLine());

double timeForLunch = lunchBreakDuration / 8.0;
double timeForRelax = lunchBreakDuration / 4.0;

double freeTime = lunchBreakDuration - timeForLunch - timeForRelax;

if (freeTime >= episodesDuration)
{
    Console.WriteLine($"You have enough time to watch {seriesTitle} and left with {Math.Ceiling(freeTime - episodesDuration)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesTitle}, you need {Math.Ceiling(episodesDuration - freeTime)} more minutes.");
}





//string seriesTitle = Console.ReadLine();
//int episodes = int.Parse(Console.ReadLine());
//int lunchBreak = int.Parse(Console.ReadLine());

//double lunch = lunchBreak / 8.0;
//double rest = lunchBreak / 4.0;

//double freeTime = lunchBreak - lunch - rest;

//if (freeTime >= episodes)
//{
//    //double timeLeft = freeTime - episodes;
//    Console.WriteLine($"You have enough time to watch {seriesTitle} and left with {Math.Ceiling(freeTime)} minutes free time.");
//}
//else
//{
//    //double timeNeeded = episodes - freeTime;
//    Console.WriteLine($"You don't have enough time to watch {seriesTitle}, you need {Math.Ceiling(freeTime)} more minutes.");
//}

//string seriesTitle = Console.ReadLine();
//int episodesDuration = int.Parse(Console.ReadLine());
//int breakDuration = int.Parse(Console.ReadLine());

//double lunchDuration = (1 / 8) * breakDuration;
//double restDuration = (1 / 4) * breakDuration;

//double freeTime = breakDuration - lunchDuration - restDuration;

//if (freeTime >= episodesDuration)
//{
//    double timeLeft = freeTime - episodesDuration;
//    Console.WriteLine($"You have enough time to watch {seriesTitle} and left with {timeLeft} minutes free time.");
//}
//else
//{
//    double timeNeeded = episodesDuration - freeTime;
//    Console.WriteLine($"You don't have enough time to watch {seriesTitle}, you need {timeNeeded} more minutes.");
//}









