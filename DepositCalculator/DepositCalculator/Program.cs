double depositSum = double.Parse(Console.ReadLine());
int srokMesec = int.Parse(Console.ReadLine());
double godLihvenProcent = double.Parse(Console.ReadLine());

double natrupanaLihva = depositSum * godLihvenProcent / 100;
double LivhaEdinMesec = natrupanaLihva / 12;
double totalSum = depositSum + srokMesec * LivhaEdinMesec;


Console.WriteLine(totalSum);

