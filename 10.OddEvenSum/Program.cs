﻿int n = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < n; i++)
{
    int currNum = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        leftSum += currNum;
    }
    else
    {
        rightSum += currNum;
    }
}
if (leftSum == rightSum)
{
    Console.WriteLine($"Yes");
    Console.WriteLine($"Sum = {leftSum}");
}
else
{
    int difference = Math.Abs(leftSum - rightSum);
    Console.WriteLine($"No");
    Console.WriteLine($"Diff = {difference}");
}

