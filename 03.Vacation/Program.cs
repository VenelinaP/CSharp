//Прочетете входните данни от конзолата:
double moneyNeeded = double.Parse(Console.ReadLine());
double jesieMoney = double.Parse(Console.ReadLine());
//Създаваме променливи за:
int daysCount = 0; //броя изминали дни
int spendingDays = 0; //броя последователни дни, в които Джеси харчи пари
//цикъл, който продължава, докато парите на Джеси са по-малко от парите, които са ѝ нужни за екскурзията
//и броячът за последователните дни е по-малък от 5.
while (jesieMoney < moneyNeeded)
{
    string input = Console.ReadLine(); //При всяко повторение на цикъла четете от конзолата два реда  първият ред е текст
    double money = double.Parse(Console.ReadLine()); //а вторият – парите, които Джеси е спестила или похарчила.
    daysCount++; //Също така увеличете брояча за дни с 1:
    //проверка дали спестява или харчи
    if (input == "spend")
    {
        spendingDays++; //увеличаваме брояча на дните, в които харчи
        if (spendingDays == 5) //проверка дали това е 5-ти пореден ден харчене, ако да принтираме:
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(daysCount);
            break; //прекратяваме цикъла
        }
        jesieMoney -= money; //от парите на Джеси изваждаме похарчените пари

        if (jesieMoney < 0)
            jesieMoney = 0;

    }
    else //save
    {
        spendingDays = 0;
        jesieMoney += money;
    }
}
if (jesieMoney >= moneyNeeded) //ако е успяла да спести
{
    Console.WriteLine($"You saved the money for {daysCount} days.");
}

     
