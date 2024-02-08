//четем размера от к и директно пресмятаме броя парчета (размера е цяло число * цяло число)
int cakeSize = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());

//създаваме променлива за вход от к 
string input = Console.ReadLine();

//въъртим цикъл до команда "STOP" 
while (input != "STOP")
{
    //=>от размера на тортата вадим броя парчета, които взимат
    cakeSize -= int.Parse(input);

    //=>проверяваме дали размера е <= 0
    if (cakeSize <= 0 )
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");//==>ако да-отпечатваме
        break; //==>прекратяваме цикъла
    }
    //=>четем нов вход от к.
    input = Console.ReadLine();    
}
if (input == "STOP") //aко последния вход е == "STOP"
{
    Console.WriteLine($"{cakeSize} pieces are left."); //отпечатваме:
}




