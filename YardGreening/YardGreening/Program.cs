double kwadratni = double.Parse(Console.ReadLine());

double price = kwadratni * 7.61;
double otstypka = 0.18 * price;
double fullPrice = price - otstypka;

Console.WriteLine($"The final price is: {fullPrice} lv.");
Console.WriteLine($"The discount is: {otstypka} lv.");
