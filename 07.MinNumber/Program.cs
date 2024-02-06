string input = Console.ReadLine();

int minNum = int.MaxValue; //когато търсим най-малкото число не започваме от 0, а от MaxValue.

while (input != "Stop")
{

    int num = int.Parse(input);

    if (num < minNum)
    {
        minNum = num;
    }

    input = Console.ReadLine();
}
Console.WriteLine(minNum);
