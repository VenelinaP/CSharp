//четем сума за връъщане и превръщаме сумата в стотинки (*100)

double changeToReturn = double.Parse(Console.ReadLine()) * 100;

//създаваме брояч на монетите за връщане
int count = 0;

//въртим цикъл, докато има сума за връщане, докато сумата е >= 1ст.
while (changeToReturn >= 1)
{
    count++; //увеличаваме брояча на монетите за връщане с 1

    //=> проверяваме дали можем да върнем монета от 200ст
    if (changeToReturn >= 200)
        changeToReturn -= 200; //==>ако да - от рестото вадим 200ст
    else if (changeToReturn >= 100) //проверяваме дали може да върнем 100ст
        changeToReturn -= 100; //==> ако може изваждаме 100ст
    else if (changeToReturn >= 50)  //ако не, проверяваме дали може 50ст.
        changeToReturn -= 50; //ако да вадим 50ст., така проверяваме за всички случай
    else if (changeToReturn >= 20)
        changeToReturn -= 20;
    else if (changeToReturn >= 10)
        changeToReturn -= 10;
    else if (changeToReturn >= 5)
        changeToReturn -= 5;
    else if (changeToReturn >= 2)
        changeToReturn -= 2;
    else
        changeToReturn = 0; //защото няма по-малко от 1
}
//отпечатваме брояча на монетите за връщане
Console.WriteLine(count);

