string destination = Console.ReadLine();

while (destination != "End")
{
    double neededMoney = double.Parse(Console.ReadLine());
    double savedMoney = 0;//променлива за спестните пари

    while (savedMoney < neededMoney) //въртим цикъл докато не спести парите
    {
        double currMoney = double.Parse(Console.ReadLine());
        savedMoney += currMoney;
    }
    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}
