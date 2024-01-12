int anualFee = int.Parse(Console.ReadLine());

double shoes = anualFee - (0.4 * anualFee);
double outfit = shoes - (0.2 * shoes);
double ball = (1.0 / 4) * outfit;
double accessories = (1.0 / 5) * ball;

double total = anualFee + shoes + ball + outfit + accessories; 

Console.WriteLine($"{total:F2}");


