int currBookPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int hoursPerDay = currBookPages / (pagesPerHour * days);

Console.WriteLine(hoursPerDay);