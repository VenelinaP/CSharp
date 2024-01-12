int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

int tank = length * width * height;
double volume = tank * 0.001; //0.001 - тъй като 1 литър = 1 кубичен дециметър
double space = percent / 100.0; //свободно пространство в аквариума
double totalLitters = volume * (1 - space);

Console.WriteLine(totalLitters);
