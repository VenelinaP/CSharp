int n = int.Parse(Console.ReadLine());
int validCombinationsCount = 0;

for (int x1 = 0; x1 <= n; x1++)
{
    for (int x2 = 0; x2 <= n; x2++)
    {
        for (int x3 = 0; x3 <= n; x3++) //може да създадем променлива за сбора(int sum = x1+x2+x3)
        {
            if (x1 + x2 + x3 == n) //(sum == n)
            {
               validCombinationsCount++;
            }
        }
    }
}
Console.WriteLine(validCombinationsCount);
