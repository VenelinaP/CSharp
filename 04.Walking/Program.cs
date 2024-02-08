//създаваме променливи за входа от конзолата и за крачки
string input;
int steps = 0;

//въртим цикъл докато направи 10000крачки
while (steps < 10000)
{
    //четем вход от к.
    input = Console.ReadLine();
    
    //=>проверяваме дали входа е "Going home"
    if(input == "Going home")
    {
        steps += int.Parse(Console.ReadLine()); //==> ako е: четем крачките до вкъщи от конзолата и ги добавяме към общия брой
        break; //===> прекратяваме цикъла
    }
    steps += int.Parse(input); //==>ако не: добавяме към общия брой към входа от к.
}
if (steps >= 10000) //проверяваме дали е постигнала целта
{
    Console.WriteLine("Goal reached! Good job!");//=>ако е-отпечатваме
    Console.WriteLine($"{steps - 10000} steps over the goal!");
}
else//=>ако нe-отпечатваме 
{
    Console.WriteLine($"{10000 - steps} more steps to reach goal.");
}




