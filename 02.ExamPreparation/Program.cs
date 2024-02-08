int faildTimes = int.Parse(Console.ReadLine());//четем от конзолата
//създаваме променливи за:
int gradeSum = 0; //сумата от всички оценки
int gradesCount = 0; //брояч за всички оценките
int badGradesCount = 0; //брояч на незадоволителни оценки

string input = Console.ReadLine(); //променлива за име на задача
string lastTask = string.Empty; //променлива за име на последната задача, може да се напише и с "";
int currTaskGrade; //променлива за оценка на задача

 //завъртаме цикъл, докато входа стане "Enough"
 while(input != "Enough")
{
    lastTask = input; //присвояваме стойността на input като име на задача
    currTaskGrade = int.Parse(Console.ReadLine()); //четем оценка от конзолата

    if (currTaskGrade <= 4) //проверяваме дали оценката е <= 4
    {
        badGradesCount++; //ако е = увеличаваме броя на незадоволителните оценки

        if(badGradesCount == faildTimes) //проверяваме дали е стигнал броя на незадоволителни оценки
        {
            Console.WriteLine($"You need a break, {badGradesCount} poor grades."); //ако е - отпечатваме:"You need a break..." и спираме цикъла
            break;
        }
    }
    gradesCount++; //добавяме оценката към сумата на всички оценки
    gradeSum += currTaskGrade;

    input = Console.ReadLine(); //четем нов вход от конзолата
 }

if (input == "Enough") //ако последния вход е = на "Enough", отпечатваме:
{
    Console.WriteLine($"Average score: {(double)gradeSum / gradesCount:f2}");
    Console.WriteLine($"Number of problems: {gradesCount}");
    Console.WriteLine($"Last problem: {lastTask}");
}
