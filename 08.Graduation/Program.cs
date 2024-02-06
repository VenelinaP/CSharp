string name = Console.ReadLine();

int grade = 1; //създаваме променлива за класа
double allGrades = 0.0; //създаваме променлива за всички оценки, които после ще добавяме към класа
int badGrades = 0;//променлива за лошите оценки

//въртим цикъл за класовете, докато е по-малък/= 12, прави нещо
while (grade <= 12)
{
    double currGrades = double.Parse(Console.ReadLine());//започваме да четем оценките

    if (currGrades < 4.00)
    {
        badGrades++;

        if (badGrades < 2)//ако получи две лоши оценки ще бъде изключен
        {
            continue;//иначе продължаваме програмата като въвеждаме нова оценка
        }
        else
        {
            Console.WriteLine($"{name} has been excluded at {grade} grade");
            break;
        }
    }

    grade++; //увеличаваме класа, ако оценката е повече от 4
    allGrades += currGrades; 
}
if (grade >= 12) //тъй като този изход е само ако е стигнал до 12 клас, ако е изключен програмата тр да спре
{
    double averageGrades = allGrades / 12; //изчисляваме средната оценка
    Console.WriteLine($"{name} graduated. Average grade: {averageGrades:f2}");
}


