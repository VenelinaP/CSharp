string input = Console.ReadLine(); //четем променливата от конзолата

//създаваме променливи за сумите на простите и непростите числа
int primeSum = 0;
int nonPrimeSum = 0;

//въртим цикъл до команда стоп
while (input != "stop")
{
    int num = int.Parse(input); //променлива за нов вход преобразуван от стринг към число
    
    if (num < 0) //проверка дали числото е отрицателно
    {
        Console.WriteLine("Number is negative.");
        input = Console.ReadLine(); //четем нов вход
        continue; //продължаваме към следващото завъртане на цикъла ако числото не е отрицателно
    }
    bool isPrime = true; //променлива за просто число
    
        for (int i = 2; i < num; i++) //цикъл докато стигнем до просто число
        {
            if (num % i == 0) //проверка дали числото е просто
            {
                isPrime = false;
            }                 
        }

        if (isPrime) //ако е просто увеличаваме сумата
           primeSum += num;
        else
            nonPrimeSum += num;
           
    input = Console.ReadLine(); //четем нов вход             
    }
    Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
    Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");


