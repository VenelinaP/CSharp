int n = int.Parse(Console.ReadLine()); //четем броя на групите
//суздаваме променливи за броя на катерачите за всеки връх

int musalaCount = 0;
int montBlancCount = 0;
int kilimanjaroCount = 0;
int k2Count = 0;
int everestCount = 0;
//и една променлива за общия брой катерачи
int totalClimbers = 0;
//въртим цикъл, който чете размера на всяка група
//и в зависимост от този размер увеличава съответната променлива
//за броя на катерачите за съответния връх.
for (int group = 1; group <= n ; group++)
{
    //извършва проверка върху текущия размер на групата
    //използваме размера на всяка група, който четем при всяка итерация на цикъла.
    int groupSize = int.Parse(Console.ReadLine()); 
    totalClimbers += groupSize; //добавяме броя на хората в групата към общия брой
    //проверява кой връх ще изкачват спрямо размера на групата и ги добавяме към съответния брояч
    if (groupSize <= 5)
        musalaCount += groupSize;
    else if (groupSize <= 12)
        montBlancCount += groupSize;
    else if (groupSize <= 25)
        kilimanjaroCount += groupSize;
    else if (groupSize <= 40)
        k2Count += groupSize;
    else
        everestCount += groupSize;
}
//извеждат се процентите за всяки връх
    Console.WriteLine($"{(double)musalaCount / totalClimbers * 100:f2}%");
    Console.WriteLine($"{(double)montBlancCount / totalClimbers * 100:f2}%");
    Console.WriteLine($"{(double)kilimanjaroCount / totalClimbers * 100:f2}%");
    Console.WriteLine($"{(double)k2Count / totalClimbers * 100:f2}%");
    Console.WriteLine($"{(double)everestCount / totalClimbers * 100:f2}%");

