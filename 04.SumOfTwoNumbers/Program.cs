int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());    
int magicN = int.Parse(Console.ReadLine());

int counter = 0;//променлива за поредността на итераторите, която в последвтвие увеличаваме
bool isFound = false;//bool променлива, с която да прекъснем ццикъла

for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        counter++;

        if (i + j == magicN)
        {
            Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicN})");
            isFound = true;
            break;
        }
    }
    if (isFound)
    {
        break;
    }
}
if (!isFound) //тази проверка е за случай, когато не е намерено число, затова има ! преди =
{
    Console.WriteLine($"{counter} combinations - neither equals {magicN}");
}

