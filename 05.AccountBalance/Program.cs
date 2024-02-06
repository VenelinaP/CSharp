string input = Console.ReadLine();

double bankAccount = 0;

while(input != "NoMoreMoney")
{
    double currAmount = double.Parse(input); //парсваме числото от инпут, защото вее сме го подали от конзолата

    if (currAmount < 0) //по условие не може да се въвеждат отрицателни числа, затова правим тази проверка, дало числото е -
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    bankAccount += currAmount; //добавяме сума към текущата сметка
    Console.WriteLine($"Increase: {currAmount:f2}");

    input = Console.ReadLine();
}
Console.WriteLine($"Total: {bankAccount:f2}"); //принтираме тотал