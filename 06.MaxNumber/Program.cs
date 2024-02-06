string input = Console.ReadLine();

int maxNum = int.MinValue; //когато търсим най-голямото число не започваме от 0, а от MinValue.

while (input != "Stop")
{
    
    int num = int.Parse(input);

    if (num > maxNum)
    {
        maxNum = num;
    }

    input = Console.ReadLine();
}
Console.WriteLine(maxNum);
