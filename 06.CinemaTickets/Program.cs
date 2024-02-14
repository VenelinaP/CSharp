//създаваме променливи за:
int studentTickets = 0; //за общия брой продадени стандартни билети
int standardTickets = 0; //за общия брой продадени студентски билети
int kidTickets = 0; //за общия брой продадени детски билети

string filmName = Console.ReadLine(); //променлива за вход от конзолата

//завъртаме цикъл до команда "Finish"
while (filmName != "Finish")
{
    int freeTickets = int.Parse(Console.ReadLine()); //=>четем броя на свободните места

    string ticketType = string.Empty; //четем от к. 
    int buyTickets = 0;

    //=>вътрешен цикъл докато закупените билети са по-малко от свободните места
    while (buyTickets < freeTickets)
    {
        ticketType = Console.ReadLine();
        if (ticketType == "End") //при команда "End" прекратяваме цикъла
            break;

        buyTickets++; //увеличаваме брояча на закупените билети с 1   

        if (ticketType == "student") //==>проверяваме какъв билет е продаден
            studentTickets++; //==>ако е "student" => увеличаваме общия брой продадени студ.билети
        else if (ticketType == "standard")
            standardTickets++; //==>ако е "stандард" => увеличаваме общия брой продадени станд.билети
        else 
            kidTickets++; //==>ако е "кид" => увеличаваме общия брой продадени детски билети
    }
    //=>отпечатваме:
    Console.WriteLine($"{filmName} - {(double)buyTickets / freeTickets * 100:f2}% full.");
    filmName = Console.ReadLine(); //=>четем ново име на филма
}
//намираме общия брой билети за всички прожекции и отпечатваме:
int totalTickets = studentTickets + standardTickets + kidTickets;

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(double)studentTickets / totalTickets * 100:f2}% student tickets.");
Console.WriteLine($"{(double)standardTickets / totalTickets * 100:f2}% standard tickets.");
Console.WriteLine($"{(double)kidTickets / totalTickets * 100:f2}% kids tickets.");